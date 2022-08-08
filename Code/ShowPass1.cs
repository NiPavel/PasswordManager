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
    public partial class ShowPass1 : Form
    {
        private string username;
        private FirebaseResponse res;
        public ShowPass1(string username)
        {
            this.username = username;
            InitializeComponent();
            this.addData();
        }

        public void addData()
        {
            int count;
            res = SignIn.getClient().Get(@"User's List/" + username + "/Count");
            count = int.Parse(res.Body.ToString());
            grid.Rows.Clear();
            grid.Columns.Clear();

            grid.Columns.Add("link", "Link");
            grid.Columns.Add("username", "Username");
            grid.Columns.Add("pass", "Password");

            for (int i = 1; i < count; i++)
            {
                res = SignIn.getClient().Get(@"User's List/" + username + "/" + i + "/");
                LinkAndPass linkandpass = res.ResultAs<LinkAndPass>();
                grid.Rows.Add(linkandpass.Link, linkandpass.Username, linkandpass.Password);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var area = new MainArea(username);
            area.Closed += (s, args) => this.Close();
            area.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var mail = new Mail(this, username);
            mail.Show();
        }

        public DataGridView getGrid()
        {
            return grid;
        }

        public void setGrid(DataGridView grid)
        {
            this.grid = grid;
        }

        private void Simul_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows != null)
            {
                string pass, key;
                pass = grid.SelectedRows[0].Cells[2].Value.ToString();
                if (pass.Length > 8)
                {
                    FirebaseResponse res = SignIn.getClient().Get(@"User's List/" + username + "/" + (grid.CurrentCell.RowIndex + 1).ToString() + "/Key/");
                    key = res.Body.ToString();
                    key = key.Replace("\"", "");
                    Encription enc = new Encription(pass, key);
                    pass = enc.Decripte();
                }
                var simulate = new Simulate(username, grid.SelectedRows[0].Cells[0].Value.ToString(), grid.SelectedRows[0].Cells[1].Value.ToString(), pass);
                simulate.Show();
            }
        }
    }
}
