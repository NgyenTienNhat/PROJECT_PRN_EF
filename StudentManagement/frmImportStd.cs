using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StudentManagement
{
    public partial class frmImportStd : Form
    {
        public frmImportStd()
        {
            InitializeComponent();
        }

        private void bt_import_Click(object sender, EventArgs e)
        {
            /*string pathConn = "Provider=Microsoft.Jet.OLEDB.12.0;Data Source=" + textBox_path.Text +
                  ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + textBox_path.Text + "$]", conn);
            conn.Open();
            DataTable dt = new DataTable();
            myDataAdapter.Fill(dt);
            dataGridView1.AutoResizeColumns();
            dataGridView1.DataSource = dt;
            for (int i = 0; i < dataGridView1.Columns.Count - 1; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                int colw = dataGridView1.Columns[i].Width;
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridView1.Columns[i].Width = colw;
            }*/
        }
        private void frmImportStd_Load(object sender, EventArgs e)
        {

        }
    }
}
