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
            Application.Exit();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_username.Text) && string.IsNullOrEmpty(textBox_password.Text))
            {
                MessageBox.Show("Username and Password Empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_username.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textBox_username.Text))
            {
                MessageBox.Show("Username Empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_username.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textBox_password.Text))
            {
                MessageBox.Show("Password Empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_password.Focus();
                return;
            }
            else
            {
                DBPContext context = new DBPContext();
                Account account = context.Accounts.FirstOrDefault(x => x.Username == textBox_username.Text && x.Password == textBox_password.Text);
                
                if (account != null)
                {
                    this.Hide();
                    frmMain main = new frmMain();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Username or Password Invalid");
                }
            }

            

        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

       
    }
}
