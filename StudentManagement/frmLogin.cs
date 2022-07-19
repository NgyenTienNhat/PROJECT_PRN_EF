using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            textBox_password.PasswordChar = '*';
        }

        private void button_exitlogin_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            /*DBPContext context = new DBPContext();
            String uname = textBox_username.Text;
            String pass = textBox_password.Text;


            if (uname == "" || pass == "")
            {
                MessageBox.Show("Input Username and Password", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (context.Accounts.Where(x => x.UserName.Equals(uname) && x.Password.Equals(pass)).ToList())
            {
                this.Hide();
                frmMain main = new frmMain();
                main.Show();
            }
            else
            {
                MessageBox.Show("Username and password are not exits", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
