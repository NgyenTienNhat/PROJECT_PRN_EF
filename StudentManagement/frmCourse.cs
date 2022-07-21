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
    public partial class frmCourse : Form
    {
        public frmCourse()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCourse_Load(object sender, EventArgs e)
        {
            openchildForm(new frmList());
        }
        private Form activeForm = null;
        private void openchildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_course.Controls.Add(childForm);
            panel_course.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_list_Click(object sender, EventArgs e)
        {
            openchildForm(new frmList());
        }

        private void button_view_Click(object sender, EventArgs e)
        {
            openchildForm(new frmView());
        }
    }
}
