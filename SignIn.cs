using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace PasswordManager
{
    public partial class SignIn : Form
    {
        private static IFirebaseClient client;
        private string username;
        public SignIn()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "wOuPO0eMASaWIi9wfmVqChfbB5OETV9vXe0TLUCn",
            BasePath = "https://passwordmanager-e1b50-default-rtdb.firebaseio.com/"
        };

        private void SignIn_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("There was a problem with an internet");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var sign = new SignUp();
            sign.Closed += (s, args) => this.Close();
            sign.Show();
        }

        public static IFirebaseClient getClient()
        {
            return client;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (correctUser())
            {
                this.Hide();
                var area = new MainArea(username);
                area.Closed += (s, args) => this.Close();
                area.Show();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect!");
            }
        }

        public Boolean correctUser()
        {
            Boolean flag = false;
            FirebaseResponse res = client.Get(@"User's List");
            Dictionary<string, Users> data = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, Users>>(res.Body.ToString());
            if (data != null)
            {
                foreach (var item in data)
                {
                    if (item.Key.ToString() == uname.Text)
                    {
                        if (item.Value.Password.ToString() == upass.Text)
                        {
                            flag = true;
                            username = item.Key.ToString();
                        }
                    }
                }
            }
            return flag;
        }

        public string getUserName()
        {
            return username;
        }
    }
}
