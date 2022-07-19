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
    public partial class frmManageClass : Form
    {
        public frmManageClass()
        {
            InitializeComponent();
        }
        private void frmManageClass_Load(object sender, EventArgs e)
        {
            LoadDataForDGV();
        }
        public void LoadDataForDGV()
        {
            DBPContext context = new DBPContext();
            dataGridView1.DataSource = context.Classes.Select(x => new { x.ClassId, x.ClassName }).ToList();
        }

        private void button_add_class_Click(object sender, EventArgs e)
        {
            DBPContext context = new DBPContext();
            Class c = GetClassInfo();
            if(textBox_classid.Text == "")
            {
                context.Add(c);
                context.SaveChanges();
                LoadDataForDGV();
            }
            else
            {
                MessageBox.Show("ClassId exists, Re-Add", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_classid.Clear();
                LoadDataForDGV();
            }
        }

        
        private Class GetClassInfo()
        {
            Class c = new Class();
            if (textBox_classid.Text != null && !string.IsNullOrWhiteSpace(textBox_classid.Text))
            {
                c.ClassId = Convert.ToInt32(textBox_classid.Text);
            }
            c.ClassName = textBox_classname.Text.Trim();
            return c;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox_classid.Text = row.Cells[0].Value.ToString();
                textBox_classname.Text = row.Cells[1].Value.ToString();
            }
        }

        private void button_update_class_Click(object sender, EventArgs e)
        {
            if (textBox_classname.Text.ToString() == "")
            {
                MessageBox.Show("ClassName Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DBPContext context = new DBPContext();
                Class c = GetClassInfo();
                context.Update(c);
                context.SaveChanges();
                LoadDataForDGV();
            }
        }
    }
}



