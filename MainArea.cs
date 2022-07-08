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
    public partial class MainArea : Form
    {   
        private string username;
        public MainArea(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addPass = new AddPassword(username);
            addPass.Closed += (s, args) => this.Close();
            addPass.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var showPass = new ShowPass1(username);
            showPass.Closed += (s, args) => this.Close();
            showPass.Show();
        }
    }
}
