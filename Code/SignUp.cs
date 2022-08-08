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

namespace PasswordManager
{
    public partial class SignUp : Form
    {
        private Boolean flag, flag1;
        private string username;
        public SignUp()
        {
            InitializeComponent();
            IncorrectPass.Hide();
            IncorrectPass2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag && flag1)
            {
                if (!this.getUsers())
                {
                    Users user = new Users()
                    {
                        UserName = name.Text,
                        Password = pass.Text,
                        Mail = mail.Text,
                        Count = 1
                    };

                    username = name.Text.ToString();
                    var setter = SignIn.getClient().Update("User's List/" + name.Text, user);
                    this.Hide();
                    var area = new MainArea(username);
                    area.Closed += (s, args) => this.Close();
                    area.Show();
                }
                else
                {
                    MessageBox.Show("The user is exist!");
                }
            }
            else
            {
                MessageBox.Show("Wrong input!");
            }
            
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            if (pass.Text.Count() < 8)
            {
                flag = false;
                IncorrectPass.Show();
                IncorrectPass.ForeColor = Color.Red;
                IncorrectPass.Text = "Password must be at least 8 symbols!";
            }
            else
            {
                IncorrectPass.Hide();
                flag = true;
            }
        }

        private void pass2_TextChanged(object sender, EventArgs e)
        {
            if (pass.Text != pass2.Text)
            {
                flag1 = false;
                IncorrectPass2.Show();
                IncorrectPass2.ForeColor = Color.Red;
                IncorrectPass2.Text = "Passwords are not the same!";
            }
            else
            {
                IncorrectPass2.Hide();
                flag1 = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var sign = new SignIn();
            sign.Closed += (s, args) => this.Close();
            sign.Show();
        }

        public Boolean getUsers()
        {
            Boolean flag = false;
            FirebaseResponse res = SignIn.getClient().Get(@"User's List");
            Dictionary<string, Users> data = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, Users>>(res.Body.ToString());
            if (data != null)
                flag = data.ContainsKey(name.Text);
            return flag;
        }
    }



}
