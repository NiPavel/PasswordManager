using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Response;
using System.Net;
using System.Net.Mail;

namespace PasswordManager
{
    public partial class Mail : Form
    {
        private int code;
        private string username;
        private ShowPass1 shp;
        public Mail(ShowPass1 shp,string username)
        {
            this.shp = shp;
            this.username = username;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            code = rnd.Next(10000, 99999);
            string mail;
            FirebaseResponse res = SignIn.getClient().Get(@"User's List/" + username + "/Mail");
            mail = res.Body.ToString();
            if (mail == '"' + email.Text.ToString() + '"')
            {

                try
                {
                    using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
                    {
                        client.EnableSsl = true;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential("pablomontana106@gmail.com", "dbdinsmybfrzpvxx");
                        MailMessage msObj = new MailMessage();
                        msObj.To.Add(email.Text);
                        msObj.From = new MailAddress("pablomontana106@gmail.com");
                        msObj.Subject = "Authentication code for Password Manager";
                        msObj.Body = code.ToString();
                        client.Send(msObj);
                    }
                }
                catch
                {
                    MessageBox.Show("Something went wrong!");
                }

                MessageBox.Show("The authentication code was sent to your mail.");
                this.Hide();
                var auth = new Authentication(shp,username, code.ToString());
                auth.Closed += (s, args) => this.Close();
                auth.Show();
            }
                
            else
                MessageBox.Show("Wrong e-mail! Try again please.");
        }
    }
}
