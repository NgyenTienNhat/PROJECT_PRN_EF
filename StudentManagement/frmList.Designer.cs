namespace StudentManagement
{
    partial class frmList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_rollno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_classname = new System.Windows.Forms.ComboBox();
            this.bt_addsubject = new System.Windows.Forms.Button();
            this.tb_stdlname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_stdfname = new System.Windows.Forms.TextBox();
            this.cb_subjname = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_stdid = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(949, 458);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tb_rollno
            // 
            this.tb_rollno.Enabled = false;
            this.tb_rollno.Location = new System.Drawing.Point(470, 541);
            this.tb_rollno.Name = "tb_rollno";
            this.tb_rollno.Size = new System.Drawing.Size(125, 27);
            this.tb_rollno.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(343, 544);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 43;
            this.label5.Text = "RollNo :";
            // 
            // cb_classname
            // 
            this.cb_classname.Enabled = false;
            this.cb_classname.FormattingEnabled = true;
            this.cb_classname.Location = new System.Drawing.Point(782, 492);
            this.cb_classname.Name = "cb_classname";
            this.cb_classname.Size = new System.Drawing.Size(131, 28);
            this.cb_classname.TabIndex = 42;
            // 
            // bt_addsubject
            // 
            this.bt_addsubject.Location = new System.Drawing.Point(819, 615);
            this.bt_addsubject.Name = "bt_addsubject";
            this.bt_addsubject.Size = new System.Drawing.Size(94, 29);
            this.bt_addsubject.TabIndex = 41;
            this.bt_addsubject.Text = "Add";
            this.bt_addsubject.UseVisualStyleBackColor = true;
            this.bt_addsubject.Click += new System.EventHandler(this.bt_addsubject_Click);
            // 
            // tb_stdlname
            // 
            this.tb_stdlname.Enabled = false;
            this.tb_stdlname.Location = new System.Drawing.Point(470, 489);
            this.tb_stdlname.Name = "tb_stdlname";
            this.tb_stdlname.Size = new System.Drawing.Size(125, 27);
            this.tb_stdlname.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(343, 492);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 39;
            this.label4.Text = "Last Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(641, 541);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "Subject Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(639, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Class ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "First Name :";
            // 
            // tb_stdfname
            // 
            this.tb_stdfname.Enabled = false;
            this.tb_stdfname.Location = new System.Drawing.Point(170, 492);
            this.tb_stdfname.Name = "tb_stdfname";
            this.tb_stdfname.Size = new System.Drawing.Size(125, 27);
            this.tb_stdfname.TabIndex = 35;
            // 
            // cb_subjname
            // 
            this.cb_subjname.FormattingEnabled = true;
            this.cb_subjname.Location = new System.Drawing.Point(782, 540);
            this.cb_subjname.Name = "cb_subjname";
            this.cb_subjname.Size = new System.Drawing.Size(131, 28);
            this.cb_subjname.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(28, 544);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 24);
            this.label6.TabIndex = 46;
            this.label6.Text = "StudentID :";
            // 
            // tb_stdid
            // 
            this.tb_stdid.Enabled = false;
            this.tb_stdid.Location = new System.Drawing.Point(170, 541);
            this.tb_stdid.Name = "tb_stdid";
            this.tb_stdid.Size = new System.Drawing.Size(125, 27);
            this.tb_stdid.TabIndex = 45;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_id.Location = new System.Drawing.Point(28, 588);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(37, 24);
            this.label_id.TabIndex = 49;
            this.label_id.Text = "ID :";
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(170, 588);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(125, 27);
            this.tb_id.TabIndex = 50;
            // 
            // frmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 714);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_stdid);
            this.Controls.Add(this.tb_rollno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_classname);
            this.Controls.Add(this.bt_addsubject);
            this.Controls.Add(this.tb_stdlname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_stdfname);
            this.Controls.Add(this.cb_subjname);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(976, 714);
            this.MinimumSize = new System.Drawing.Size(976, 714);
            this.Name = "frmList";
            this.Text = "frmManageSubjOfStd";
            this.Load += new System.EventHandler(this.frmManageSubjOfStd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_rollno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_classname;
        private System.Windows.Forms.Button bt_addsubject;
        private System.Windows.Forms.TextBox tb_stdlname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_stdfname;
        private System.Windows.Forms.ComboBox cb_subjname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_stdid;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox tb_id;
    }
}