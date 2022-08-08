using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Simulate : Form
    {
        private string username, link, login, password;

        public Simulate(string username, string link, string login, string password)
        {
            this.username = username;
            this.link = link;
            this.login = login;
            this.password = password;
            InitializeComponent();
            lablink.Text = this.link;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(uname.Text==login && upass.Text == password)
            {
                MessageBox.Show("Signed in");
            }
            else
                MessageBox.Show("Error!Wrong username or password");
        }
    }
}
