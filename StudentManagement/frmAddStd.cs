using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace StudentManagement
{
    public partial class frmAddStd : Form
    {
        public frmAddStd()
            {
                InitializeComponent();

            }
        private void frmAddStd_Load(object sender, EventArgs e)
            {
            DBPContext context = new DBPContext();
            LoadDataForDGV();
            comboBox_class.DataSource = context.Classes.Select(x => x.ClassName).Distinct().ToList();
            }
        public void LoadDataForDGV()
            {
                DBPContext context = new DBPContext();
                dataGridView1.DataSource = context.Students.Select(x => new { x.StudentId, x.FirstName, x.LastName, x.Dob, x.Male, x.Mobile, x.RollNo, x.Address, x.ClassId }).ToList();

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



        private void button_add_std_Click(object sender, EventArgs e)
        {
            if (textBox_fname.Text.ToString() == "" || textBox_lname.Text.ToString() == "" || textBox_rollno.Text.ToString() == "" || textBox_mobile.Text.ToString() == "")
            {
                MessageBox.Show("Infomation Student Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DBPContext context = new DBPContext();
                Student s = GetStudentInfo();
                context.Students.Add(s);
                context.SaveChanges();
                LoadDataForDGV();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            textBox_Id.Clear();
            textBox_lname.Clear();
            textBox_fname.Clear();
            textBox_mobile.Clear();
            textBox_rollno.Clear();
            textBox_address.Clear();
        }

        /*private void button_upload_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "Image File | *.png; *.jpg; *.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }*/

        private void bt_import_Click(object sender, EventArgs e)
        {
            frmImportStd import = new frmImportStd();
            import.Show();
        }
    }
}



        