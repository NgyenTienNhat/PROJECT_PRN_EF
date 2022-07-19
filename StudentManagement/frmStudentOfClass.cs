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
    public partial class frmStudentOfClass : Form
    {
        public frmStudentOfClass()
        {
            InitializeComponent();
        }

        private void frmStudentOfClass_Load(object sender, EventArgs e)
        {
            DBPContext context = new DBPContext();
            LoadDataForDGV();
            comboBox_classname.DataSource = context.Classes.Select(x => x.ClassName).ToList();

        }
        public void LoadDataForDGV()
        {
            DBPContext context = new DBPContext();
            var datadataGridViewAddStudent = (from s in context.Students
                                              join c in context.Classes on s.ClassId equals c.ClassId
                                             
                                              select new
                                              {
                                                  FistName = s.FirstName,
                                                  LastName = s.LastName,
                                                  Mobile = s.Mobile,
                                                  Dob = s.Dob,
                                                  Male = s.Male,
                                                  RollNo = s.RollNo,
                                                  ClassName = c.ClassName
                                              }).OrderBy(x => x.FistName).ToList();
            dataGridView1.DataSource = datadataGridViewAddStudent;
        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            DBPContext context = new DBPContext();
            int keyword = context.Classes.FirstOrDefault(x => x.ClassName.Equals(comboBox_classname.SelectedItem)).ClassId;
            dataGridView1.DataSource = context.Students.Where(x => x.ClassId.Equals(keyword))
                .Select(x => new { x.FirstName, x.LastName, x.Dob, x.Male, x.Mobile, x.RollNo, x.ClassId })
                .OrderBy(x => x.FirstName).ToList();
            textBox_countmale.Text = context.Students.Where(x => x.Male == true && x.ClassId.Equals(keyword)).ToList().Count.ToString();
            textBox_countfemale.Text = context.Students.Where(x => x.Male == false && x.ClassId.Equals(keyword)).ToList().Count.ToString();
            tb_totalstdofclass.Text = context.Students.Where(x => x.StudentId != null && x.ClassId.Equals(keyword)).ToList().Count.ToString();

        }
     }
}

