namespace StudentManagement
{
    partial class frmEditStd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_addstd = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_totalstd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_fname = new System.Windows.Forms.TextBox();
            this.button_searchbyname = new System.Windows.Forms.Button();
            this.comboBox_class = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.button_delete_std = new System.Windows.Forms.Button();
            this.button_update_std = new System.Windows.Forms.Button();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_rollno = new System.Windows.Forms.TextBox();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_dob = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_mobile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_lname = new System.Windows.Forms.TextBox();
            this.panel_register = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_addstd.SuspendLayout();
            this.panel_register.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlCommandBuilder1
            // 
            this.sqlCommandBuilder1.DataAdapter = null;
            this.sqlCommandBuilder1.QuotePrefix = "[";
            this.sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(952, 323);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 36);
            this.panel1.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(-1, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 24);
            this.label12.TabIndex = 49;
            this.label12.Text = "MANAGE STUDENT";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(834, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 27);
            this.button1.TabIndex = 48;
            this.button1.Text = "Reload";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(371, -92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "MANAGE STUDENT";
            // 
            // panel_addstd
            // 
            this.panel_addstd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_addstd.Controls.Add(this.label11);
            this.panel_addstd.Controls.Add(this.tb_totalstd);
            this.panel_addstd.Controls.Add(this.label10);
            this.panel_addstd.Controls.Add(this.textBox_fname);
            this.panel_addstd.Controls.Add(this.button_searchbyname);
            this.panel_addstd.Controls.Add(this.comboBox_class);
            this.panel_addstd.Controls.Add(this.label9);
            this.panel_addstd.Controls.Add(this.textBox_search);
            this.panel_addstd.Controls.Add(this.label8);
            this.panel_addstd.Controls.Add(this.textBox_Id);
            this.panel_addstd.Controls.Add(this.button_delete_std);
            this.panel_addstd.Controls.Add(this.button_update_std);
            this.panel_addstd.Controls.Add(this.textBox_address);
            this.panel_addstd.Controls.Add(this.textBox_rollno);
            this.panel_addstd.Controls.Add(this.radioButton_female);
            this.panel_addstd.Controls.Add(this.radioButton_male);
            this.panel_addstd.Controls.Add(this.label6);
            this.panel_addstd.Controls.Add(this.label5);
            this.panel_addstd.Controls.Add(this.label4);
            this.panel_addstd.Controls.Add(this.dateTimePicker_dob);
            this.panel_addstd.Controls.Add(this.label3);
            this.panel_addstd.Controls.Add(this.textBox_mobile);
            this.panel_addstd.Controls.Add(this.label2);
            this.panel_addstd.Controls.Add(this.label1);
            this.panel_addstd.Controls.Add(this.textBox_lname);
            this.panel_addstd.Location = new System.Drawing.Point(8, 379);
            this.panel_addstd.Name = "panel_addstd";
            this.panel_addstd.Size = new System.Drawing.Size(952, 316);
            this.panel_addstd.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(468, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 24);
            this.label11.TabIndex = 49;
            this.label11.Text = "Total Student :";
            // 
            // tb_totalstd
            // 
            this.tb_totalstd.Enabled = false;
            this.tb_totalstd.Location = new System.Drawing.Point(611, 12);
            this.tb_totalstd.Name = "tb_totalstd";
            this.tb_totalstd.Size = new System.Drawing.Size(94, 27);
            this.tb_totalstd.TabIndex = 48;
            this.tb_totalstd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(10, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 24);
            this.label10.TabIndex = 47;
            this.label10.Text = "First Name :";
            // 
            // textBox_fname
            // 
            this.textBox_fname.Location = new System.Drawing.Point(153, 98);
            this.textBox_fname.Name = "textBox_fname";
            this.textBox_fname.PlaceholderText = "Enter Name";
            this.textBox_fname.Size = new System.Drawing.Size(152, 27);
            this.textBox_fname.TabIndex = 46;
            // 
            // button_searchbyname
            // 
            this.button_searchbyname.BackColor = System.Drawing.SystemColors.Control;
            this.button_searchbyname.Location = new System.Drawing.Point(330, 12);
            this.button_searchbyname.Name = "button_searchbyname";
            this.button_searchbyname.Size = new System.Drawing.Size(92, 27);
            this.button_searchbyname.TabIndex = 45;
            this.button_searchbyname.Text = "Search";
            this.button_searchbyname.UseVisualStyleBackColor = false;
            this.button_searchbyname.Click += new System.EventHandler(this.button_searchbyname_Click);
            // 
            // comboBox_class
            // 
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.Location = new System.Drawing.Point(611, 183);
            this.comboBox_class.Name = "comboBox_class";
            this.comboBox_class.Size = new System.Drawing.Size(123, 28);
            this.comboBox_class.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(468, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 24);
            this.label9.TabIndex = 42;
            this.label9.Text = "Class Name :";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(10, 12);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.PlaceholderText = "Search/ABC/CID...";
            this.textBox_search.Size = new System.Drawing.Size(295, 27);
            this.textBox_search.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(10, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Student ID :";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Enabled = false;
            this.textBox_Id.Location = new System.Drawing.Point(153, 54);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(152, 27);
            this.textBox_Id.TabIndex = 18;
            // 
            // button_delete_std
            // 
            this.button_delete_std.BackColor = System.Drawing.SystemColors.Control;
            this.button_delete_std.Location = new System.Drawing.Point(504, 265);
            this.button_delete_std.Name = "button_delete_std";
            this.button_delete_std.Size = new System.Drawing.Size(160, 39);
            this.button_delete_std.TabIndex = 17;
            this.button_delete_std.Text = "Delete";
            this.button_delete_std.UseVisualStyleBackColor = false;
            this.button_delete_std.Click += new System.EventHandler(this.button_delete_std_Click);
            // 
            // button_update_std
            // 
            this.button_update_std.BackColor = System.Drawing.SystemColors.Control;
            this.button_update_std.Location = new System.Drawing.Point(287, 265);
            this.button_update_std.Name = "button_update_std";
            this.button_update_std.Size = new System.Drawing.Size(160, 39);
            this.button_update_std.TabIndex = 16;
            this.button_update_std.Text = "Update";
            this.button_update_std.UseVisualStyleBackColor = false;
            this.button_update_std.Click += new System.EventHandler(this.button_update_std_Click);
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(611, 142);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.PlaceholderText = "Enter Address";
            this.textBox_address.Size = new System.Drawing.Size(297, 27);
            this.textBox_address.TabIndex = 13;
            // 
            // textBox_rollno
            // 
            this.textBox_rollno.Location = new System.Drawing.Point(611, 98);
            this.textBox_rollno.Name = "textBox_rollno";
            this.textBox_rollno.PlaceholderText = "Enter RollNo";
            this.textBox_rollno.Size = new System.Drawing.Size(129, 27);
            this.textBox_rollno.TabIndex = 12;
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Location = new System.Drawing.Point(227, 227);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(78, 24);
            this.radioButton_female.TabIndex = 11;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Location = new System.Drawing.Point(153, 227);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(63, 24);
            this.radioButton_male.TabIndex = 10;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(468, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(468, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "RollNumber :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender :";
            // 
            // dateTimePicker_dob
            // 
            this.dateTimePicker_dob.Checked = false;
            this.dateTimePicker_dob.CustomFormat = "";
            this.dateTimePicker_dob.Location = new System.Drawing.Point(611, 54);
            this.dateTimePicker_dob.Name = "dateTimePicker_dob";
            this.dateTimePicker_dob.Size = new System.Drawing.Size(227, 27);
            this.dateTimePicker_dob.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(468, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dob :";
            // 
            // textBox_mobile
            // 
            this.textBox_mobile.Location = new System.Drawing.Point(153, 183);
            this.textBox_mobile.Name = "textBox_mobile";
            this.textBox_mobile.PlaceholderText = "Enter Mobile";
            this.textBox_mobile.Size = new System.Drawing.Size(152, 27);
            this.textBox_mobile.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mobile :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name :";
            // 
            // textBox_lname
            // 
            this.textBox_lname.Location = new System.Drawing.Point(153, 139);
            this.textBox_lname.Name = "textBox_lname";
            this.textBox_lname.PlaceholderText = "Enter Name";
            this.textBox_lname.Size = new System.Drawing.Size(152, 27);
            this.textBox_lname.TabIndex = 1;
            // 
            // panel_register
            // 
            this.panel_register.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_register.Controls.Add(this.panel_addstd);
            this.panel_register.Controls.Add(this.panel1);
            this.panel_register.Controls.Add(this.dataGridView1);
            this.panel_register.Location = new System.Drawing.Point(5, 1);
            this.panel_register.Name = "panel_register";
            this.panel_register.Size = new System.Drawing.Size(963, 698);
            this.panel_register.TabIndex = 21;
            // 
            // frmEditStd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 697);
            this.Controls.Add(this.panel_register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(972, 697);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(972, 697);
            this.Name = "frmEditStd";
            this.Text = "frmManageStd";
            this.Load += new System.EventHandler(this.frmManageStd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_addstd.ResumeLayout(false);
            this.panel_addstd.PerformLayout();
            this.panel_register.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel_addstd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_totalstd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_fname;
        private System.Windows.Forms.Button button_searchbyname;
        private System.Windows.Forms.ComboBox comboBox_class;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Button button_delete_std;
        private System.Windows.Forms.Button button_update_std;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_rollno;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_mobile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_lname;
        private System.Windows.Forms.Panel panel_register;
        private System.Windows.Forms.Label label12;
    }
}