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
            tb_totalteacher.Text = context.Teachers.Where(x => x.TeacherId != null).ToList().Count.ToString();

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

        public Teacher GetInfoTeacher()
        {
            DBPContext context = new DBPContext();
            Teacher teacher = new Teacher();
            if (tb_idteacher.Text != null && !string.IsNullOrWhiteSpace(tb_idteacher.Text))
            {
                teacher.TeacherId = Convert.ToInt32(tb_idteacher.Text);
            }
            teacher.TeacherName = tb_nameteacher.Text;
            teacher.Dob = dateTimePicker_dob.Value;
            teacher.Address = tb_address.Text;
            teacher.Mobile = tb_mobileteacher.Text;
            teacher.Male = radioButton_male.Checked;
            return teacher;
        }

        private void button_delete_std_Click(object sender, EventArgs e)
        {
            DBPContext context = new DBPContext();
            string mess = tb_nameteacher.Text;
            if( tb_nameteacher.Text =="" || tb_idteacher.Text == "" || tb_mobileteacher.Text == "" || tb_address.Text == "")
            {
                MessageBox.Show("Please select the teacher you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Teacher teacher = GetInfoTeacher();
                context.Remove(teacher);
                context.SaveChanges();
                tb_address.Clear();
                tb_idteacher.Clear();
                tb_mobileteacher.Clear();
                tb_nameteacher.Clear();
                LoadDataForDGV();
                MessageBox.Show("Delete teacher "+mess+" successfull!");

            }
        }

        private void button_update_std_Click(object sender, EventArgs e)
        {
            DBPContext context = new DBPContext();
            string mess = tb_nameteacher.Text;
            if (tb_nameteacher.Text == "" || tb_idteacher.Text == "" || tb_mobileteacher.Text == "" || tb_address.Text == "")
            {
                MessageBox.Show("Please select the teacher you want to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Teacher teacher = GetInfoTeacher();
                context.Update(teacher);
                context.SaveChanges();
                LoadDataForDGV();
                MessageBox.Show("Update info teacher "+mess+" Successfull!");
                tb_address.Clear();
                tb_idteacher.Clear();
                tb_mobileteacher.Clear();
                tb_nameteacher.Clear();
            }
        }

        private void button_searchbyname_Click(object sender, EventArgs e)
        {
            DBPContext context = new DBPContext();
            string keyword = textBox_search.Text.Trim();
           
            if (textBox_search.Text == "")
            {
                if (checkBox_sort.Checked == true )
                {
                    dataGridView1.DataSource = context.Teachers.Select(x => new { x.TeacherId, x.TeacherName, x.Dob, x.Male, x.Mobile, x.Address }).OrderBy(x => x.TeacherName).ToList();
                    tb_totalteacher.Text = context.Teachers.Where(x => x.TeacherName.Contains(keyword)).ToList().Count.ToString();

                }
                else
                {
                    dataGridView1.DataSource = context.Teachers.Select(x => new { x.TeacherId, x.TeacherName, x.Dob, x.Male, x.Mobile, x.Address }).ToList();
                    tb_totalteacher.Text = context.Teachers.Where(x => x.TeacherName.Contains(keyword)).ToList().Count.ToString();

                }
            }
            else if(textBox_search.Text != "")
            {
                if(checkBox_sort.Checked == true)
                {
                    dataGridView1.DataSource = context.Teachers.Select(x => new
                    {
                        x.TeacherId,
                        x.TeacherName,
                        x.Dob,
                        x.Male,
                        x.Mobile,
                        x.Address
                    }).Where(x => x.TeacherName.Contains(keyword)
                    || x.Mobile.Contains(keyword)
                    || x.Address.Contains(keyword)).OrderBy(x => x.TeacherName).ToList();
                    tb_totalteacher.Text = context.Teachers.Where(x => x.TeacherName.Contains(keyword)).ToList().Count.ToString();

                }
                else
                {
                    dataGridView1.DataSource = context.Teachers.Select(x => new
                    {
                        x.TeacherId,
                        x.TeacherName,
                        x.Dob,
                        x.Male,
                        x.Mobile,
                        x.Address
                    }).Where(x => x.TeacherName.Contains(keyword)
                    || x.Mobile.Contains(keyword)
                    || x.Address.Contains(keyword)).ToList();
                    tb_totalteacher.Text = context.Teachers.Where(x => x.TeacherName.Contains(keyword)).ToList().Count.ToString();

                }
            }
            else
            {
                dataGridView1.DataSource = context.Teachers.Select(x => new
                {
                    x.TeacherId,
                    x.TeacherName,
                    x.Dob,
                    x.Male,
                    x.Mobile,
                    x.Address
                }).Where(x => x.TeacherName.Contains(keyword)
                || x.Mobile.Contains(keyword)
                || x.Address.Contains(keyword)).ToList();
                tb_totalteacher.Text = context.Teachers.Where(x => x.TeacherName.Contains(keyword)).ToList().Count.ToString();

            }
        }

        private void button_reload_Click(object sender, EventArgs e)
        {
            LoadDataForDGV();
            textBox_search.Clear();
            checkBox_sort.Checked = false;
        }

        private void checkBox_sort_CheckedChanged(object sender, EventArgs e)
        {
            DBPContext context = new DBPContext();
            string keyword = textBox_search.Text.Trim();
            if (checkBox_sort.Checked == true)
            {
                dataGridView1.DataSource = context.Teachers.Select(x => new
                {
                    x.TeacherId,
                    x.TeacherName,
                    x.Dob,
                    x.Male,
                    x.Mobile,
                    x.Address
                }).Where(x => x.TeacherName.Contains(keyword)
                || x.Mobile.Contains(keyword)
                || x.Address.Contains(keyword)).OrderBy(x => x.TeacherName).ToList();
                tb_totalteacher.Text = context.Teachers.Where(x => x.TeacherName.Contains(keyword)).ToList().Count.ToString();
            }
            else
            {
                dataGridView1.DataSource = context.Teachers.Select(x => new
                {
                    x.TeacherId,
                    x.TeacherName,
                    x.Dob,
                    x.Male,
                    x.Mobile,
                    x.Address
                }).Where(x => x.TeacherName.Contains(keyword)
                || x.Mobile.Contains(keyword)
                || x.Address.Contains(keyword)).ToList();
                tb_totalteacher.Text = context.Teachers.Where(x => x.TeacherName.Contains(keyword)).ToList().Count.ToString();
            }
            // text > cb> search done
            // text > search > checkbox pending
        }
    }
}
