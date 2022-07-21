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
    public partial class frmMarks : Form
    {
        public frmMarks()
        {
            InitializeComponent();
        }

        private void frmMarks_Load(object sender, EventArgs e)
        {
            LoadDataForDGV();
        }
        public void LoadDataForDGV()
        {
            DBPContext context = new DBPContext();

            var data = 
            (from m in context.Marks
             join s in context.Students on m.StudentId equals s.StudentId
             join subj in context.Subjects on m.SubjectId equals subj.SubjectId
             select
             new
             {
                 Id = m.Id,
                 StudentId = s.StudentId,
                 SubjectId = subj.SubjectId,
                 ProgessTest = m.ProgessTest,
                 MidtermTest = m.MidtermTest,
                 FinalTest = m.FinalTest,
                 FinalTestAgain = m.FinalTestAgain,
                 Note = m.Note
             }).ToList();
            dataGridView1.DataSource = data;
        }
    }
}
