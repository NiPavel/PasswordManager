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
    public partial class AddPassword : Form
    {
        private List<char> chars = new List<char>();
        private Boolean flag;
        private string username;
        public AddPassword(string username)
        {
            this.username = username;
            InitializeComponent();
            IncorrectLink.Hide();
            IncorrectPass.Hide();
            IncorrectUser.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var area = new MainArea(username);
            area.Closed += (s, args) => this.Close();
            area.Show();
        }

        public void addChars(ref List<char> chars)
        {
            for (char c = 'a'; c <= 'z'; c++)
                chars.Add(c);
            for (char c = 'A'; c <= 'Z'; c++)
                chars.Add(c);
            for (char c = '0'; c <= '9'; c++)
                chars.Add(c);
            for (char c = '!'; c <= '?'; c++)
            {
                if (c != '"' )
                    chars.Add(c);
            }
        }

        public string genPass(int length)
        {
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            int i = 0;

            while (i < length)
            {
                sb.Append(chars[rnd.Next(0, chars.Count)]);
                i++;
                if (i == length - 1)
                {
                    if (!sb.ToString().Any(char.IsUpper) || !sb.ToString().Any(char.IsLower) || !sb.ToString().Any(char.IsDigit) || !sb.ToString().Any(char.IsPunctuation))
                    {
                        sb.Clear();
                        i = 0;
                    }
                }
            }
            return sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addChars(ref chars);
            pass.Text = genPass(8);
        }

        private void link_TextChanged(object sender, EventArgs e)
        {
            if (link.Text.Count() == 0)
            {
                flag = false;
                IncorrectLink.Show();
                IncorrectLink.ForeColor = Color.Red;
                IncorrectLink.Text = "Fill the blank please!";
            }
            else
            {
                flag = true;
                IncorrectLink.Hide();
            }
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            if (pass.Text.Count() != 8)
            {
                flag = false;
                IncorrectPass.Show();
                IncorrectPass.ForeColor = Color.Red;
                IncorrectPass.Text = "Password must be 8 symbols!";
            }
            else if (!pass.Text.Any(char.IsUpper) || !pass.Text.Any(char.IsLower) || !pass.Text.Any(char.IsNumber) || !pass.Text.Any(char.IsPunctuation))
            {
                flag = false;
                IncorrectPass.Show();
                IncorrectPass.ForeColor = Color.Red;
                IncorrectPass.Text = "Password must be Strong!";
            }
            else if (user1.Text.Count() <= 0)
            {
                flag = false;
                IncorrectUser.Show();
                IncorrectUser.ForeColor = Color.Red;
                IncorrectUser.Text = "Input an username!";
            }
            else
            {
                flag = true;
                IncorrectPass.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count;
            string temp, key;
            if (flag)
            {
                if (chars.Count == 0)
                    addChars(ref chars);
                key = genPass(8);
                Encription text = new Encription(pass.Text.ToString(), key);
                temp = text.Encripte();
                LinkAndPass linkandpass = new LinkAndPass
                {
                    Link = link.Text,
                    Username = user.Text,
                    Password = temp,
                    Key = key
                };
                int i = 0;
                FirebaseResponse res = SignIn.getClient().Get(@"User's List/" + username + "/Count");
                count = int.Parse(res.Body.ToString());
                var setter = SignIn.getClient().Update("User's List/" + username + "/" + count, linkandpass);
                count++;
                var setter2 = SignIn.getClient().Set(@"User's List/" + username + "/Count", count);
                MessageBox.Show("You have added a new Password for a " + link.Text);
                
            }
            else
            {
                pass.Text = "";
            }
        }

        
    }
}
