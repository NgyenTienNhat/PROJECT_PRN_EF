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
    public partial class frmTeacherSubject : Form
    {
        public frmTeacherSubject()
        {
            InitializeComponent();
        }

        private void frmSubjectOfClass_Load(object sender, EventArgs e)
        {
            DBPContext context = new DBPContext();
            LoadDataForDGV();
            cb_classname.DataSource = context.Classes.Select(x => x.ClassName).Distinct().ToList();
            cb_subjectname.DataSource = context.Subjects.Select(x => x.SubjectName).Distinct().ToList();
            cb_teachername.DataSource = context.Teachers.Select(x => x.TeacherName).Distinct().ToList();
        }
        public void LoadDataForDGV()
        {
            DBPContext context = new DBPContext();
            var data = (from ts in context.TeacherSubjects
                        join c in context.Classes on ts.ClassId equals c.ClassId
                        join t in context.Teachers on ts.TeacherId equals t.TeacherId
                        join s in context.Subjects on ts.SubjectId equals s.SubjectId
                        select new
                              {
                               Id = ts.Id,
                               ClassName = c.ClassName,
                               TeacherName = t.TeacherName,
                               SubjectName = s.SubjectName
                               }).ToList();
            dataGridView1.DataSource = data;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tb_id.Text = row.Cells[0].Value.ToString();
                cb_subjectname.Text = row.Cells[3].Value.ToString();
                cb_teachername.Text = row.Cells[2].Value.ToString();
                cb_classname.Text = row.Cells[1].Value.ToString();
            }
        }

        public TeacherSubject GetInfoSOCAdd()
        {
            DBPContext context = new DBPContext();
            TeacherSubject ts = new TeacherSubject();
            ts.ClassId = context.Classes.FirstOrDefault(x => x.ClassName.Equals(cb_classname.SelectedItem)).ClassId;
            ts.TeacherId = context.Teachers.FirstOrDefault(x => x.TeacherName.Equals(cb_teachername.SelectedItem)).TeacherId;
            ts.SubjectId = context.Subjects.FirstOrDefault(x => x.SubjectName.Equals(cb_subjectname.SelectedItem)).SubjectId;
            return ts;
        }
        public TeacherSubject GetInfoSOCUpdate()
        {
            DBPContext context = new DBPContext();
            TeacherSubject ts = new TeacherSubject();
            if (tb_id.Text != null && !string.IsNullOrWhiteSpace(tb_id.Text))
            {
                ts.Id = Convert.ToInt32(tb_id.Text);
            }
            ts.ClassId = context.Classes.FirstOrDefault(x => x.ClassName.Equals(cb_classname.SelectedItem)).ClassId;
            ts.SubjectId = context.Subjects.FirstOrDefault(x => x.SubjectName.Equals(cb_subjectname.SelectedItem)).SubjectId;
            ts.TeacherId = context.Teachers.FirstOrDefault(x => x.TeacherName.Equals(cb_teachername.SelectedItem)).TeacherId;
            return ts;
        }

        private void button_add_std_Click(object sender, EventArgs e)
        {
            DBPContext context = new DBPContext();
           /* if (cb_subjectid.Text.ToString() != context.Subjects.Select(x => x.SubjectId).ToString() 
                || cb_teacherid.Text.ToString() != context.Teachers.Select(x => x.TeacherId).ToString()
                || cb_classid.Text.ToString() != context.Classes.Select(x => x.ClassId).ToString())
            {
                MessageBox.Show("Input Dont Correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {*/
                TeacherSubject ts = GetInfoSOCAdd();
                context.Add(ts);
                context.SaveChanges();
                LoadDataForDGV();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_subjectname.Text.ToString() == "" || cb_teachername.Text.ToString() == "" || cb_classname.Text.ToString() == "")
            {
                MessageBox.Show("Infomation Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DBPContext context = new DBPContext();
                TeacherSubject ts = GetInfoSOCUpdate();
                context.Update(ts);
                context.SaveChanges();
                LoadDataForDGV();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            if (cb_subjectname.Text.ToString() == "" || cb_teachername.Text.ToString() == "" || cb_classname.Text.ToString() == "")
            {
                MessageBox.Show("Infomation Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DBPContext context = new DBPContext();
                TeacherSubject ts = GetInfoSOCUpdate();
                context.Remove(ts);
                context.SaveChanges();
                LoadDataForDGV();
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DBPContext context = new DBPContext();
            String keywork = textBox_search.Text.Trim();
            var data = (from ts in context.TeacherSubjects
                        join c in context.Classes on ts.ClassId equals c.ClassId
                        join t in context.Teachers on ts.TeacherId equals t.TeacherId
                        join s in context.Subjects on ts.SubjectId equals s.SubjectId
                        select new
                        {
                            Id = ts.Id,
                            ClassName = c.ClassName,
                            TeacherName = t.TeacherName,
                            SubjectName = s.SubjectName
                        }).Where(x => x.ClassName.Contains(keywork)
                                || x.TeacherName.Contains(keywork)
                                || x.SubjectName.Contains(keywork)).ToList();
            dataGridView1.DataSource = data;

        }

        private void button_reload_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }
    }
}
