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
    public partial class frmEditTeacher : Form
    {
        public frmEditTeacher()
        {
            InitializeComponent();
        }

        private void frmEditTeacher_Load(object sender, EventArgs e)
        {
            LoadDataForDGV();
        }
        public void LoadDataForDGV()
        {
            DBPContext context = new DBPContext();
            dataGridView1.DataSource = context.Teachers.Select(x => new { x.TeacherId, x.TeacherName, x.Dob, x.Male, x.Mobile, x.Address }).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tb_idteacher.Text = row.Cells[0].Value.ToString();
                tb_nameteacher.Text = row.Cells[1].Value.ToString();
                dateTimePicker_dob.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
                if ((Boolean)row.Cells[3].Value == false)
                {
                    radioButton_female.Checked = true;
                }
                else
                {
                    radioButton_male.Checked = true;
                }
                tb_mobileteacher.Text = row.Cells[4].Value.ToString();
                tb_address.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
