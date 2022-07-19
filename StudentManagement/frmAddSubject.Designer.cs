namespace StudentManagement
{
    partial class frmAddSubject
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_update_subject = new System.Windows.Forms.Button();
            this.button_add_subject = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_subjectid = new System.Windows.Forms.TextBox();
            this.button_add_std = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_subjectname = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_update_subject);
            this.panel3.Controls.Add(this.button_add_subject);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.textBox_subjectid);
            this.panel3.Controls.Add(this.button_add_std);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBox_subjectname);
            this.panel3.Location = new System.Drawing.Point(490, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(471, 640);
            this.panel3.TabIndex = 28;
            // 
            // button_update_subject
            // 
            this.button_update_subject.BackColor = System.Drawing.SystemColors.Control;
            this.button_update_subject.Location = new System.Drawing.Point(267, 597);
            this.button_update_subject.Name = "button_update_subject";
            this.button_update_subject.Size = new System.Drawing.Size(160, 39);
            this.button_update_subject.TabIndex = 45;
            this.button_update_subject.Text = "Update";
            this.button_update_subject.UseVisualStyleBackColor = false;
            this.button_update_subject.Click += new System.EventHandler(this.button_update_subject_Click);
            // 
            // button_add_subject
            // 
            this.button_add_subject.BackColor = System.Drawing.SystemColors.Control;
            this.button_add_subject.Location = new System.Drawing.Point(44, 597);
            this.button_add_subject.Name = "button_add_subject";
            this.button_add_subject.Size = new System.Drawing.Size(160, 39);
            this.button_add_subject.TabIndex = 44;
            this.button_add_subject.Text = "Add";
            this.button_add_subject.UseVisualStyleBackColor = false;
            this.button_add_subject.Click += new System.EventHandler(this.button_add_subject_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(79, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 24);
            this.label9.TabIndex = 43;
            this.label9.Text = "Subject ID :";
            // 
            // textBox_subjectid
            // 
            this.textBox_subjectid.Enabled = false;
            this.textBox_subjectid.Location = new System.Drawing.Point(225, 65);
            this.textBox_subjectid.Name = "textBox_subjectid";
            this.textBox_subjectid.Size = new System.Drawing.Size(153, 27);
            this.textBox_subjectid.TabIndex = 42;
            // 
            // button_add_std
            // 
            this.button_add_std.BackColor = System.Drawing.SystemColors.Control;
            this.button_add_std.Location = new System.Drawing.Point(578, 293);
            this.button_add_std.Name = "button_add_std";
            this.button_add_std.Size = new System.Drawing.Size(160, 39);
            this.button_add_std.TabIndex = 38;
            this.button_add_std.Text = "Add";
            this.button_add_std.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(79, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Subject Name:";
            // 
            // textBox_subjectname
            // 
            this.textBox_subjectname.Location = new System.Drawing.Point(225, 122);
            this.textBox_subjectname.Name = "textBox_subjectname";
            this.textBox_subjectname.PlaceholderText = "Enter Name";
            this.textBox_subjectname.Size = new System.Drawing.Size(153, 27);
            this.textBox_subjectname.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 8);
            this.panel2.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(9, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 36);
            this.panel1.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(0, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 24);
            this.label12.TabIndex = 49;
            this.label12.Text = "ADD SUBJECT";
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(475, 640);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // frmAddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 694);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(970, 694);
            this.Name = "frmAddSubject";
            this.Text = "frmAddSubject";
            this.Load += new System.EventHandler(this.frmAddSubject_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_subjectid;
        private System.Windows.Forms.Button button_add_std;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_subjectname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_update_subject;
        private System.Windows.Forms.Button button_add_subject;
        private System.Windows.Forms.Label label12;
    }
}