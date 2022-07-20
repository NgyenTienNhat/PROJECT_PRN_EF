namespace StudentManagement
{
    partial class frmEditTeacher
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
            this.panel_addstd = new System.Windows.Forms.Panel();
            this.checkBox_sort = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_totalteacher = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_nameteacher = new System.Windows.Forms.TextBox();
            this.button_searchbyname = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_idteacher = new System.Windows.Forms.TextBox();
            this.button_delete_std = new System.Windows.Forms.Button();
            this.button_update_std = new System.Windows.Forms.Button();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_dob = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_mobileteacher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_reload = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_addstd.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_addstd
            // 
            this.panel_addstd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_addstd.Controls.Add(this.checkBox_sort);
            this.panel_addstd.Controls.Add(this.label11);
            this.panel_addstd.Controls.Add(this.tb_totalteacher);
            this.panel_addstd.Controls.Add(this.label10);
            this.panel_addstd.Controls.Add(this.tb_nameteacher);
            this.panel_addstd.Controls.Add(this.button_searchbyname);
            this.panel_addstd.Controls.Add(this.textBox_search);
            this.panel_addstd.Controls.Add(this.label8);
            this.panel_addstd.Controls.Add(this.tb_idteacher);
            this.panel_addstd.Controls.Add(this.button_delete_std);
            this.panel_addstd.Controls.Add(this.button_update_std);
            this.panel_addstd.Controls.Add(this.tb_address);
            this.panel_addstd.Controls.Add(this.radioButton_female);
            this.panel_addstd.Controls.Add(this.radioButton_male);
            this.panel_addstd.Controls.Add(this.label6);
            this.panel_addstd.Controls.Add(this.label4);
            this.panel_addstd.Controls.Add(this.dateTimePicker_dob);
            this.panel_addstd.Controls.Add(this.label3);
            this.panel_addstd.Controls.Add(this.tb_mobileteacher);
            this.panel_addstd.Controls.Add(this.label2);
            this.panel_addstd.Location = new System.Drawing.Point(12, 522);
            this.panel_addstd.Margin = new System.Windows.Forms.Padding(4);
            this.panel_addstd.Name = "panel_addstd";
            this.panel_addstd.Size = new System.Drawing.Size(1190, 342);
            this.panel_addstd.TabIndex = 22;
            // 
            // checkBox_sort
            // 
            this.checkBox_sort.AutoSize = true;
            this.checkBox_sort.Location = new System.Drawing.Point(1013, 17);
            this.checkBox_sort.Name = "checkBox_sort";
            this.checkBox_sort.Size = new System.Drawing.Size(104, 29);
            this.checkBox_sort.TabIndex = 50;
            this.checkBox_sort.Text = "SortABC";
            this.checkBox_sort.UseVisualStyleBackColor = true;
            this.checkBox_sort.CheckedChanged += new System.EventHandler(this.checkBox_sort_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(590, 15);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 29);
            this.label11.TabIndex = 49;
            this.label11.Text = "Total Teacher :";
            // 
            // tb_totalteacher
            // 
            this.tb_totalteacher.Enabled = false;
            this.tb_totalteacher.Location = new System.Drawing.Point(769, 11);
            this.tb_totalteacher.Margin = new System.Windows.Forms.Padding(4);
            this.tb_totalteacher.Name = "tb_totalteacher";
            this.tb_totalteacher.Size = new System.Drawing.Size(116, 31);
            this.tb_totalteacher.TabIndex = 48;
            this.tb_totalteacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(12, 132);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 29);
            this.label10.TabIndex = 47;
            this.label10.Text = "Teacher Name :";
            // 
            // tb_nameteacher
            // 
            this.tb_nameteacher.Location = new System.Drawing.Point(191, 129);
            this.tb_nameteacher.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nameteacher.Name = "tb_nameteacher";
            this.tb_nameteacher.PlaceholderText = "Enter Name";
            this.tb_nameteacher.Size = new System.Drawing.Size(189, 31);
            this.tb_nameteacher.TabIndex = 46;
            // 
            // button_searchbyname
            // 
            this.button_searchbyname.BackColor = System.Drawing.SystemColors.Control;
            this.button_searchbyname.Location = new System.Drawing.Point(400, 15);
            this.button_searchbyname.Margin = new System.Windows.Forms.Padding(4);
            this.button_searchbyname.Name = "button_searchbyname";
            this.button_searchbyname.Size = new System.Drawing.Size(115, 34);
            this.button_searchbyname.TabIndex = 45;
            this.button_searchbyname.Text = "Search";
            this.button_searchbyname.UseVisualStyleBackColor = false;
            this.button_searchbyname.Click += new System.EventHandler(this.button_searchbyname_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(12, 15);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.PlaceholderText = "Search here....";
            this.textBox_search.Size = new System.Drawing.Size(368, 31);
            this.textBox_search.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "Teacher ID :";
            // 
            // tb_idteacher
            // 
            this.tb_idteacher.Enabled = false;
            this.tb_idteacher.Location = new System.Drawing.Point(191, 73);
            this.tb_idteacher.Margin = new System.Windows.Forms.Padding(4);
            this.tb_idteacher.Name = "tb_idteacher";
            this.tb_idteacher.Size = new System.Drawing.Size(189, 31);
            this.tb_idteacher.TabIndex = 18;
            // 
            // button_delete_std
            // 
            this.button_delete_std.BackColor = System.Drawing.SystemColors.Control;
            this.button_delete_std.Location = new System.Drawing.Point(630, 286);
            this.button_delete_std.Margin = new System.Windows.Forms.Padding(4);
            this.button_delete_std.Name = "button_delete_std";
            this.button_delete_std.Size = new System.Drawing.Size(200, 49);
            this.button_delete_std.TabIndex = 17;
            this.button_delete_std.Text = "Delete";
            this.button_delete_std.UseVisualStyleBackColor = false;
            this.button_delete_std.Click += new System.EventHandler(this.button_delete_std_Click);
            // 
            // button_update_std
            // 
            this.button_update_std.BackColor = System.Drawing.SystemColors.Control;
            this.button_update_std.Location = new System.Drawing.Point(359, 286);
            this.button_update_std.Margin = new System.Windows.Forms.Padding(4);
            this.button_update_std.Name = "button_update_std";
            this.button_update_std.Size = new System.Drawing.Size(200, 49);
            this.button_update_std.TabIndex = 16;
            this.button_update_std.Text = "Update";
            this.button_update_std.UseVisualStyleBackColor = false;
            this.button_update_std.Click += new System.EventHandler(this.button_update_std_Click);
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(769, 183);
            this.tb_address.Margin = new System.Windows.Forms.Padding(4);
            this.tb_address.Name = "tb_address";
            this.tb_address.PlaceholderText = "Enter Address";
            this.tb_address.Size = new System.Drawing.Size(370, 31);
            this.tb_address.TabIndex = 13;
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Location = new System.Drawing.Point(910, 73);
            this.radioButton_female.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(93, 29);
            this.radioButton_female.TabIndex = 11;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Location = new System.Drawing.Point(769, 73);
            this.radioButton_male.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(75, 29);
            this.radioButton_male.TabIndex = 10;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(590, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Address :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(590, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender :";
            // 
            // dateTimePicker_dob
            // 
            this.dateTimePicker_dob.Checked = false;
            this.dateTimePicker_dob.CustomFormat = "";
            this.dateTimePicker_dob.Location = new System.Drawing.Point(769, 126);
            this.dateTimePicker_dob.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_dob.Name = "dateTimePicker_dob";
            this.dateTimePicker_dob.Size = new System.Drawing.Size(348, 31);
            this.dateTimePicker_dob.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(590, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dob :";
            // 
            // tb_mobileteacher
            // 
            this.tb_mobileteacher.Location = new System.Drawing.Point(191, 182);
            this.tb_mobileteacher.Margin = new System.Windows.Forms.Padding(4);
            this.tb_mobileteacher.Name = "tb_mobileteacher";
            this.tb_mobileteacher.PlaceholderText = "Enter Mobile";
            this.tb_mobileteacher.Size = new System.Drawing.Size(189, 31);
            this.tb_mobileteacher.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mobile :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_reload);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 45);
            this.panel1.TabIndex = 21;
            // 
            // button_reload
            // 
            this.button_reload.Location = new System.Drawing.Point(1075, 6);
            this.button_reload.Name = "button_reload";
            this.button_reload.Size = new System.Drawing.Size(112, 34);
            this.button_reload.TabIndex = 50;
            this.button_reload.Text = "Reload";
            this.button_reload.UseVisualStyleBackColor = true;
            this.button_reload.Click += new System.EventHandler(this.button_reload_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(-1, 8);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 29);
            this.label12.TabIndex = 49;
            this.label12.Text = "MANAGE TEACHER";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(464, -115);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 35);
            this.label7.TabIndex = 0;
            this.label7.Text = "MANAGE STUDENT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1190, 456);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // frmEditTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 871);
            this.Controls.Add(this.panel_addstd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1215, 871);
            this.MinimumSize = new System.Drawing.Size(1215, 871);
            this.Name = "frmEditTeacher";
            this.Text = "frmEditTeacher";
            this.Load += new System.EventHandler(this.frmEditTeacher_Load);
            this.panel_addstd.ResumeLayout(false);
            this.panel_addstd.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_addstd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_totalteacher;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_nameteacher;
        private System.Windows.Forms.Button button_searchbyname;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_idteacher;
        private System.Windows.Forms.Button button_delete_std;
        private System.Windows.Forms.Button button_update_std;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_mobileteacher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_reload;
        private System.Windows.Forms.CheckBox checkBox_sort;
    }
}