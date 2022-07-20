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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void customizeDesign()
        {
            panel_stdsubmenu.Visible= false;
            panel_coursesubmenu.Visible= false;
            panel_scoresubmenu.Visible= false;
            panel_classsubmenu.Visible= false;
        }

        private void hideSubmenu()
        {
            if(panel_stdsubmenu.Visible == true)
               panel_stdsubmenu.Visible = false;
            if (panel_coursesubmenu.Visible == true)
                panel_coursesubmenu.Visible = false;
            if (panel_scoresubmenu.Visible == true)
                panel_scoresubmenu.Visible = false;
            if (panel_classsubmenu.Visible == true)
                panel_classsubmenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else 
                submenu.Visible = false;
        }

        private void button_std_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_stdsubmenu);
        }

        private void button_registration_Click(object sender, EventArgs e)
        {
            openchildForm(new frmAddStd());
            hideSubmenu();
        }

        private Form activeForm = null;
        private void openchildForm(Form childForm)
        {
            if(activeForm != null)
               activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_managestd_Click(object sender, EventArgs e)
        {
            openchildForm(new frmEditStd());
            hideSubmenu();

        }

        private void button_status_Click(object sender, EventArgs e)
        {
           // hideSubmenu();

        }

        private void button_course_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_coursesubmenu);
        }

        private void button_newcourse_Click(object sender, EventArgs e)
        {
            openchildForm(new frmAddSubject());
            hideSubmenu();

        }

        private void button_managecourse_Click(object sender, EventArgs e)
        {
            openchildForm(new frmTeacherSubject());
            hideSubmenu();

        }

        private void button_teacher_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_scoresubmenu);
        }

        private void button_addteacher_Click(object sender, EventArgs e)
        {
            openchildForm(new frmAddTeacher());
            hideSubmenu();
        }

        private void button_editteacher_Click(object sender, EventArgs e)
        {
            openchildForm(new frmEditTeacher());
            hideSubmenu();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button_class_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_classsubmenu);
        }

        private void button_manageclass_Click(object sender, EventArgs e)
        {
            openchildForm(new frmManageClass());
            hideSubmenu();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_stdofclass_Click(object sender, EventArgs e)
        {
            openchildForm(new frmStudentOfClass());
            hideSubmenu();
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_dboard_Click(object sender, EventArgs e)
        {
            openchildForm(new frmDashboard());
        }
    }
}
