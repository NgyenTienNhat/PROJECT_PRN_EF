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
    public partial class frmAddTeacher : Form
    {
        public frmAddTeacher()
        {
            InitializeComponent();
        }
        
        

        private void frmAddTeacher_Load(object sender, EventArgs e)
        {
            LoadDataForDGV();
        }

        public void LoadDataForDGV()
        {
            DBPContext context = new DBPContext();
            dataGridView1.DataSource = context.Teachers.Select(x => new { x.TeacherId, x.TeacherName, x.Dob, x.Male, x.Mobile, x.Address }).ToList();
        }

        public Teacher GetInfoTeacher()
        {
            DBPContext context = new DBPContext();
            Teacher teacher = new Teacher();
            teacher.TeacherName = tb_teachername.Text.Trim();
            teacher.Mobile = tb_mobile.Text.Trim();
            teacher.Address = tb_address.Text.Trim();
            teacher.Dob = dateTimePicker_dob.Value;
            teacher.Male = radioButton_male.Checked;
            return teacher;
        }

        private void button_add_teacher_Click(object sender, EventArgs e)
        {
            DBPContext context = new DBPContext();
            Teacher teacher = GetInfoTeacher();
            context.Add(teacher);
            context.SaveChanges();
            LoadDataForDGV();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            tb_teachername.Clear();
            tb_mobile.Clear();
            tb_address.Clear();
            tb_teacherid.Clear();
        }
    }
}
