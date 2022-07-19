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
    public partial class frmAddSubject : Form
    {
        public frmAddSubject()
        {
            InitializeComponent();
        }

        private void frmAddSubject_Load(object sender, EventArgs e)
        {
            LoadDataForDGV();
        }
        public void LoadDataForDGV()
        {
            DBPContext context = new DBPContext();
            dataGridView1.DataSource = context.Subjects.Select(x => new { x.SubjectId, x.SubjectName }).ToList();
        }

        private Subject GetSubjectInfo()
        {
            Subject subj = new Subject();
            if (textBox_subjectid.Text != null && !string.IsNullOrWhiteSpace(textBox_subjectid.Text))
            {
                subj.SubjectId = Convert.ToInt32(textBox_subjectid.Text);
            }
            subj.SubjectName = textBox_subjectname.Text.Trim();
            return subj;
        }


        private void button_add_subject_Click(object sender, EventArgs e)
        {
            DBPContext context = new DBPContext();
            Subject subj = GetSubjectInfo();
            if (textBox_subjectname.Text != "")
            {
                context.Add(subj);
                context.SaveChanges();
                LoadDataForDGV();
            }
            else
            {
                MessageBox.Show("SubjectId exists, Re-Add", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_subjectid.Clear();
                LoadDataForDGV();
            }
        }
        private void button_update_subject_Click(object sender, EventArgs e)
        {

            if (textBox_subjectname.Text.ToString() == "")
            {
                MessageBox.Show("SubjectName Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DBPContext context = new DBPContext();
                Subject subj = GetSubjectInfo();
                context.Update(subj);
                context.SaveChanges();
                LoadDataForDGV();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox_subjectid.Text = row.Cells[0].Value.ToString();
                textBox_subjectname.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
