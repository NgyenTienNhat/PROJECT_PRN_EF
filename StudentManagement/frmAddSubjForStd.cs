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
    public partial class frmAddSubjForStd : Form
    {
        public frmAddSubjForStd()
        {
            InitializeComponent();
        }

        private void frmAddSubjForStd_Load(object sender, EventArgs e)
        {
            DBPContext context = new DBPContext();
            cb_subjname.DataSource = context.Subjects.Select(x => x.SubjectName).ToList();
            cb_classname.DataSource = context.Classes.Select(x => x.ClassName).ToList();
            LoadDataForDGV();
        }

        public void LoadDataForDGV()
        {
            DBPContext context = new DBPContext();
            var data = (from s in context.Students
                        join c in context.Classes on s.ClassId equals c.ClassId
                        select new
                                 {FistName = s.FirstName,
                                  LastName = s.LastName,
                                  RollNo = s.RollNo,
                                  ClassName = c.ClassName,
                                  SubjectName = ""
                                  })
                        .OrderBy(x => x.FistName).ToList();
            dataGridView1.DataSource = data;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tb_stdfname.Text= row.Cells[0].Value.ToString(); 
                tb_stdlname.Text= row.Cells[1].Value.ToString();
                cb_classname.Text= row.Cells[3].Value.ToString();
                cb_subjname.Text= row.Cells[4].Value.ToString();
            }
        }
        public  SubjectStudent GetInfoSubject()
        {
            DBPContext context = new DBPContext();
            SubjectStudent ss = new SubjectStudent();
            ss.SubjectId = context.Subjects.FirstOrDefault(x => x.SubjectName.Equals(cb_subjname.SelectedItem)).SubjectId;
            ss.ClassId = context.Classes.FirstOrDefault(x => x.ClassName.Equals(cb_classname.SelectedItem)).ClassId;
            ss.StudentId = context.Students.FirstOrDefault(x => x.FirstName.Equals(tb_stdfname)).StudentId;
            return ss;
        }
        private void bt_addsubject_Click(object sender, EventArgs e)
        {
            DBPContext context = new DBPContext();
            SubjectStudent ss = GetInfoSubject();
            if (tb_stdfname.Text != "" || tb_stdlname.Text != "")
            {
                context.Add(ss);
                context.SaveChanges();
                var data = (from subs in context.SubjectStudents
                            join c in context.Classes on ss.ClassId equals c.ClassId
                            join s in context.Students on ss.StudentId equals s.StudentId
                            join subj in context.Subjects on ss.SubjectId equals subj.SubjectId
                            select new{ 
                                FistName = s.FirstName,
                                LastName = s.LastName,
                                RollNo = s.RollNo,
                                ClassName = c.ClassName,
                                SubjectName = subj.SubjectName
                            }).OrderBy(x => x.FistName).ToList();
                dataGridView1.DataSource = data;
            }
            else
            {
                MessageBox.Show("SubjectId exists, Re-Add", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);               
                LoadDataForDGV();
            }
        }
    }
}
