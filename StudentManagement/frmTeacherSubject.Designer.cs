namespace StudentManagement
{
    partial class frmTeacherSubject
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
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add_std = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_reload = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.cb_classname = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.cb_teachername = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_subjectname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.SystemColors.Control;
            this.button_delete.Location = new System.Drawing.Point(291, 596);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(100, 40);
            this.button_delete.TabIndex = 39;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_add_std
            // 
            this.button_add_std.BackColor = System.Drawing.SystemColors.Control;
            this.button_add_std.Location = new System.Drawing.Point(23, 596);
            this.button_add_std.Name = "button_add_std";
            this.button_add_std.Size = new System.Drawing.Size(110, 40);
            this.button_add_std.TabIndex = 38;
            this.button_add_std.Text = "Add";
            this.button_add_std.UseVisualStyleBackColor = false;
            this.button_add_std.Click += new System.EventHandler(this.button_add_std_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(369, -92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 28);
            this.label10.TabIndex = 1;
            this.label10.Text = "ADD NEW STUDENT";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(354, -125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "ADD NEW STUDENT";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.button_reload);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(9, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 36);
            this.panel1.TabIndex = 26;
            // 
            // button_reload
            // 
            this.button_reload.Location = new System.Drawing.Point(849, 3);
            this.button_reload.Name = "button_reload";
            this.button_reload.Size = new System.Drawing.Size(78, 27);
            this.button_reload.TabIndex = 52;
            this.button_reload.Text = "Reload";
            this.button_reload.UseVisualStyleBackColor = true;
            this.button_reload.Click += new System.EventHandler(this.button_reload_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_search);
            this.panel3.Controls.Add(this.textBox_search);
            this.panel3.Controls.Add(this.tb_id);
            this.panel3.Controls.Add(this.cb_classname);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.button_update);
            this.panel3.Controls.Add(this.cb_teachername);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cb_subjectname);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button_delete);
            this.panel3.Controls.Add(this.button_add_std);
            this.panel3.Location = new System.Drawing.Point(539, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 646);
            this.panel3.TabIndex = 28;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(239, 18);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(78, 27);
            this.button_search.TabIndex = 51;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(49, 18);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(156, 27);
            this.textBox_search.TabIndex = 50;
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(205, 73);
            this.tb_id.Margin = new System.Windows.Forms.Padding(2);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(112, 27);
            this.tb_id.TabIndex = 49;
            // 
            // cb_classname
            // 
            this.cb_classname.AllowDrop = true;
            this.cb_classname.FormattingEnabled = true;
            this.cb_classname.Location = new System.Drawing.Point(205, 269);
            this.cb_classname.Margin = new System.Windows.Forms.Padding(2);
            this.cb_classname.Name = "cb_classname";
            this.cb_classname.Size = new System.Drawing.Size(112, 28);
            this.cb_classname.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(46, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 47;
            this.label4.Text = "Class Name :";
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.SystemColors.Control;
            this.button_update.Location = new System.Drawing.Point(161, 596);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(106, 40);
            this.button_update.TabIndex = 46;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_teachername
            // 
            this.cb_teachername.AllowDrop = true;
            this.cb_teachername.FormattingEnabled = true;
            this.cb_teachername.Location = new System.Drawing.Point(205, 198);
            this.cb_teachername.Margin = new System.Windows.Forms.Padding(2);
            this.cb_teachername.Name = "cb_teachername";
            this.cb_teachername.Size = new System.Drawing.Size(112, 28);
            this.cb_teachername.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(46, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "Teacher Name :";
            // 
            // cb_subjectname
            // 
            this.cb_subjectname.AllowDrop = true;
            this.cb_subjectname.FormattingEnabled = true;
            this.cb_subjectname.Location = new System.Drawing.Point(205, 130);
            this.cb_subjectname.Margin = new System.Windows.Forms.Padding(2);
            this.cb_subjectname.Name = "cb_subjectname";
            this.cb_subjectname.Size = new System.Drawing.Size(112, 28);
            this.cb_subjectname.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Subject Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "ID :";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 8);
            this.panel2.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(524, 647);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(0, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(273, 24);
            this.label12.TabIndex = 53;
            this.label12.Text = "MANAGE SUBJECT OF TEACHER";
            // 
            // frmTeacherSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 647);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(970, 694);
            this.Name = "frmTeacherSubject";
            this.Text = "frmSubjectOfClass";
            this.Load += new System.EventHandler(this.frmSubjectOfClass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add_std;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_classname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.ComboBox cb_teachername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_subjectname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_reload;
        private System.Windows.Forms.Label label12;
    }
}