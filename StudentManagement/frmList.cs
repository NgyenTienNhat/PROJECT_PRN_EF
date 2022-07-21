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
    public partial class frmList : Form
    {
        public frmList()
        {
            InitializeComponent();
        }

        private void frmManageSubjOfStd_Load(object sender, EventArgs e)
        {
            DBPContext context = new DBPContext();
            cb_subjname.DataSource = context.Subjects.Select(x => x.SubjectName).ToList();
            LoadDataForDGV();
            bt_addsubject.Show();
            tb_id.Hide();
            label_id.Hide();
        }
        public void LoadDataForDGV()
        {
            DBPContext context = new DBPContext();
            var data = context.Students.Select(x => new
            {
                StudentId = x.StudentId,
                FistName = x.FirstName,
                LastName = x.LastName,
                RollNo = x.RollNo,
                ClassId = x.ClassId,
            }).ToList();
            dataGridView1.DataSource = data;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tb_stdid.Text = row.Cells[0].Value.ToString();
                tb_stdfname.Text = row.Cells[1].Value.ToString();
                tb_stdlname.Text = row.Cells[2].Value.ToString();
                tb_rollno.Text = row.Cells[3].Value.ToString();
                cb_classname.Text = row.Cells[4].Value.ToString();
            }
        }


        public SubjectStudent GetSubjectAddToSubjectStudent()
        {
            DBPContext context = new DBPContext();
            SubjectStudent ss = new SubjectStudent();
            ss.SubjectId = context.Subjects.FirstOrDefault(x => x.SubjectName == cb_subjname.Text).SubjectId;
            ss.StudentId = Convert.ToInt32(tb_stdid.Text);
            return ss;
        }
       

        private void bt_addsubject_Click(object sender, EventArgs e)
        {   
            string fname = tb_stdfname.Text;
            string lname = tb_stdlname.Text;
            DBPContext context = new DBPContext();
            SubjectStudent ss = GetSubjectAddToSubjectStudent();
            context.Add(ss);
            context.SaveChanges();
            MessageBox.Show("Add course for [" + lname + " " + fname + "] successful.");
            
        }
    }
}
