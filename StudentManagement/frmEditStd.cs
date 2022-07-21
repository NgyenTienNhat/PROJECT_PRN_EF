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
    public partial class frmEditStd : Form
    {
        public frmEditStd()
        {
            InitializeComponent();
        }

        private void frmManageStd_Load(object sender, EventArgs e)
        {
            DBPContext context = new DBPContext();
            LoadDataForDGV();
            comboBox_class.DataSource = context.Classes.Select(x => x.ClassName).Distinct().ToList();
            tb_totalstd.Text = context.Students.Where(x => x.StudentId != null).ToList().Count.ToString();

        }

        public void LoadDataForDGV()
        {
            DBPContext context = new DBPContext();
            var datadataGridViewAddStudent = (from s in context.Students
                                              join c in context.Classes on s.ClassId equals c.ClassId
                                              select new
                                              {
                                                  StudentId = s.StudentId,
                                                  FistName = s.FirstName,
                                                  LastName = s.LastName,
                                                  Mobile = s.Mobile,
                                                  Dob = s.Dob,
                                                  Male = s.Male,
                                                  RollNo = s.RollNo,
                                                  Address = s.Address,
                                                  ClassName = c.ClassName
                                              }).ToList();
            dataGridView1.DataSource = datadataGridViewAddStudent;
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox_Id.Text = row.Cells[0].Value.ToString();
                textBox_fname.Text = row.Cells[1].Value.ToString();
                textBox_lname.Text = row.Cells[2].Value.ToString();
                textBox_mobile.Text = row.Cells[3].Value.ToString();
                dateTimePicker_dob.Value = Convert.ToDateTime(row.Cells[4].Value.ToString());
                if ((Boolean)row.Cells[5].Value == false)
                {
                    radioButton_female.Checked = true;
                }
                else
                {
                    radioButton_male.Checked = true;
                }
                textBox_rollno.Text = row.Cells[6].Value.ToString();
                textBox_address.Text = row.Cells[7].Value.ToString();
                comboBox_class.SelectedItem = row.Cells[8].Value.ToString();
            }
        }

        public Student GetStudentInfo()
        {
            DBPContext context = new DBPContext();
            Student s = new Student();
            if (textBox_Id.Text != null && !string.IsNullOrWhiteSpace(textBox_Id.Text))
            {
                s.StudentId = Convert.ToInt32(textBox_Id.Text);
            }
            s.LastName = textBox_lname.Text.Trim();
            s.FirstName = textBox_fname.Text.Trim();
            s.Mobile = textBox_mobile.Text;
            s.Dob = dateTimePicker_dob.Value;
            s.Male = radioButton_male.Checked;
            s.RollNo = textBox_rollno.Text.Trim();
            s.Address = textBox_address.Text.Trim();
            s.ClassId = context.Classes.FirstOrDefault(x => x.ClassName.Equals(comboBox_class.SelectedItem)).ClassId;
            return s;
        }

        private void button_searchbyname_Click(object sender, EventArgs e)
        {
            DBPContext context = new DBPContext();
            string keyword = textBox_search.Text.Trim();

            /*if (keyword.Contains("ABC"))
            {
                var datadataGridViewStudent = (from s in context.Students
                                                  join c in context.Classes on s.ClassId equals c.ClassId
                                                  select new
                                                  {
                                                      StudentId = s.StudentId,
                                                      FistName = s.FirstName,
                                                      LastName = s.LastName,
                                                      Mobile = s.Mobile,
                                                      Dob = s.Dob,
                                                      Male = s.Male,
                                                      RollNo = s.RollNo,
                                                      Address = s.Address,
                                                      ClassName = c.ClassName
                                                  }).OrderBy(x => x.FistName).ToList();
                dataGridView1.DataSource = datadataGridViewStudent;
               


            }
            else if (keyword.Contains("CID"))
            {
                var datadataGridViewStudent = (from s in context.Students
                                                  join c in context.Classes on s.ClassId equals c.ClassId
                                                  select new
                                                  {
                                                      StudentId = s.StudentId,
                                                      FistName = s.FirstName,
                                                      LastName = s.LastName,
                                                      Mobile = s.Mobile,
                                                      Dob = s.Dob,
                                                      Male = s.Male,
                                                      RollNo = s.RollNo,
                                                      Address = s.Address,
                                                      ClassName = c.ClassName
                                                  }).OrderBy(x => x.ClassName).ToList();
                dataGridView1.DataSource = datadataGridViewStudent;
                tb_totalstd.Text = datadataGridViewStudent.Where(x => x.StudentId != null).ToList().Count.ToString();
            }
            else
            {*/
                var datadataGridViewStudent = (from s in context.Students
                                               join c in context.Classes on s.ClassId equals c.ClassId
                                               select new
                                               {
                                                   StudentId = s.StudentId,
                                                   FistName = s.FirstName,
                                                   LastName = s.LastName,
                                                   Mobile = s.Mobile,
                                                   Dob = s.Dob,
                                                   Male = s.Male,
                                                   RollNo = s.RollNo,
                                                   Address = s.Address,
                                                   ClassName = c.ClassName
                                               }).Where(x => x.FistName.Contains(keyword)
                || x.LastName.Contains(keyword)
                || x.RollNo.Contains(keyword)
                || x.Mobile.Contains(keyword)
                || x.Address.Contains(keyword)
                ).ToList();
                dataGridView1.DataSource = datadataGridViewStudent;
                tb_totalstd.Text = datadataGridViewStudent.Where(x => x.FistName.Contains(keyword)|| x.LastName.Contains(keyword)|| x.RollNo.Contains(keyword)|| x.Mobile.Contains(keyword)|| x.Address.Contains(keyword)).ToList().Count.ToString();

                /* dataGridView1.DataSource = context.Students.Where(x => x.FirstName.Contains(keyword)
                 || x.LastName.Contains(keyword)
                 || x.RollNo.Contains(keyword)
                 || x.Mobile.Contains(keyword)
                 || x.Address.Contains(keyword)
                 ).Select(x => new { x.StudentId, x.FirstName, x.LastName, x.Dob, x.Male, x.Mobile, x.RollNo, x.Address, x.ClassId }).ToList();*/
        }
        

        private void button_update_std_Click(object sender, EventArgs e)
        {
            if (textBox_fname.Text.ToString() == "" || textBox_lname.Text.ToString() == "" || textBox_rollno.Text.ToString() == "" || textBox_mobile.Text.ToString() == "")
            {
                MessageBox.Show("Please select the student you want to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DBPContext context = new DBPContext();
                Student s = GetStudentInfo();
                context.Update(s);
                context.SaveChanges();
                MessageBox.Show("Update infomation student successfull!");
                textBox_Id.Clear();
                textBox_fname.Clear();
                textBox_lname.Clear();
                textBox_rollno.Clear();
                textBox_mobile.Clear();
                textBox_address.Clear();
                LoadDataForDGV();
            }
        }

        private void button_delete_std_Click(object sender, EventArgs e)
        {
            string fistname = textBox_fname.Text;
            string lastname = textBox_lname.Text;
            if (textBox_fname.Text.ToString() == "" || textBox_lname.Text.ToString() == "" || textBox_rollno.Text.ToString() == "" || textBox_mobile.Text.ToString() == "")
            {
                MessageBox.Show("Please select the student you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DBPContext context = new DBPContext();
                Student s = GetStudentInfo();
                context.Remove(s);
                context.SaveChanges();
                MessageBox.Show("Delete student [" + lastname + " "+ fistname +"] successfull!");
                textBox_Id.Clear();
                textBox_fname.Clear();
                textBox_lname.Clear();
                textBox_rollno.Clear();
                textBox_mobile.Clear();
                textBox_address.Clear();
                LoadDataForDGV();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBPContext context = new DBPContext();
            LoadDataForDGV();
            tb_totalstd.Text = context.Students.Where(x => x.StudentId != null).ToList().Count.ToString();
            textBox_search.Clear();
        }
    }
}
