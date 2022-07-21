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
    public partial class frmView : Form
    {
        public frmView()
        {
            InitializeComponent();
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            DBPContext context = new DBPContext();
            LoadDataForDGV();
            tb_id.Hide();
            label_id.Hide();
            cb_subjname.DataSource = context.Subjects.Select(x => x.SubjectName).Distinct().ToList();
        }
        public void LoadDataForDGV()
        {   
            DBPContext context = new DBPContext();
            var data = (from subjstd in context.SubjectStudents
                        join s in context.Students on subjstd.StudentId equals s.StudentId
                        join sub in context.Subjects on subjstd.SubjectId equals sub.SubjectId
                        select new
                        {
                            ID = subjstd.Id,
                            StudentId = s.StudentId,
                            FistName = s.FirstName,
                            LastName = s.LastName,
                            RollNo = s.RollNo,
                            ClassId = s.ClassId,
                            SubjectName = sub.SubjectName
                        }).ToList();
            dataGridView1.DataSource = data;
        }

        public SubjectStudent GetSubjectUpdate()
        {
            DBPContext context = new DBPContext();
            SubjectStudent ss = new SubjectStudent();
            ss.Id = Convert.ToInt32(tb_id.Text);
            ss.SubjectId = context.Subjects.FirstOrDefault(x => x.SubjectName == cb_subjname.Text).SubjectId;
            ss.StudentId = Convert.ToInt32(tb_stdid.Text);
            return ss;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string fname = tb_stdfname.Text;
            string lname = tb_stdlname.Text;
            DBPContext context = new DBPContext();
            SubjectStudent ss = GetSubjectUpdate();
            context.Update(ss);
            context.SaveChanges();
            MessageBox.Show("Update course for [" + lname + " " + fname + "] successful.");
            LoadDataForDGV();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string fname = tb_stdfname.Text;
            string lname = tb_stdlname.Text;
            DBPContext context = new DBPContext();
            SubjectStudent ss = GetSubjectUpdate();
            context.Remove(ss);
            context.SaveChanges();
            MessageBox.Show("Delete course for [" + lname + " " + fname + "] successful.");
            LoadDataForDGV();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DBPContext context = new DBPContext();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tb_id.Text = row.Cells[0].Value.ToString();
                tb_stdid.Text = row.Cells[1].Value.ToString();
                tb_stdfname.Text = row.Cells[2].Value.ToString();
                tb_stdlname.Text = row.Cells[3].Value.ToString();
                tb_rollno.Text = row.Cells[4].Value.ToString();
                cb_classname.Text = row.Cells[5].Value.ToString();
                cb_subjname.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}
