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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
            tb_pass.PasswordChar = '*';
            tb_repass.PasswordChar = '*';
            tb_oldpass.PasswordChar = '*';
        }
        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }
       
        private void bt_save_Click(object sender, EventArgs e)
        {
            DBPContext context = new DBPContext();
            Account account = context.Accounts.FirstOrDefault(x => x.Username == tb_user.Text && x.Password == tb_oldpass.Text);
            if (account != null)
            {
                if (tb_pass.Text == "")
                {
                    MessageBox.Show("New Password Empty.");
                }
                else if (tb_repass.Text == "" || tb_pass.Text != tb_repass.Text)
                {
                    MessageBox.Show("Repass Invalid");
                }
                else
                {
                    Account acc = context.Accounts.Single(x => x.Username == tb_user.Text);
                    acc.Password = tb_pass.Text;
                    context.SaveChanges();
                    MessageBox.Show("Change password successful","Message");
                }

            }
            else
            {
                MessageBox.Show("Username or Password Invalid");
            }
        }
    }
}
