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
    public partial class Authentication : Form
    {
        private string username, code;
        private ShowPass1 shp;
        public Authentication(ShowPass1 shp,string username, string code)
        {
            this.shp = shp;
            this.username = username;
            this.code = code;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (code == acode.Text)
            {
                int count;
                string temp, key;
                DataGridView grid = shp.getGrid();
                if (grid != null)
                {
                    count = grid.Rows.Count;
                    for (int i = 0; i< count; i++)
                    {
                        temp = grid.Rows[i].Cells[2].Value.ToString();
                        FirebaseResponse res = SignIn.getClient().Get(@"User's List/" + username + "/" + (i + 1).ToString() + "/Key/");
                        key = res.Body.ToString();
                        key = key.Replace("\"", "");
                        Console.WriteLine(key);
                        Encription enc = new Encription(temp, key);
                        temp = enc.Decripte();
                        grid.Rows[i].Cells[2].Value = temp;
                    }

                    this.Hide();
                    shp.Closed += (s, args) => this.Close();
                }
            }
            else
                MessageBox.Show("Authentication code is incorrect!");
        }
    }
}
