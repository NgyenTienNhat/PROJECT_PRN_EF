namespace StudentManagement
{
    partial class frmAddSubjForStd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_subjname = new System.Windows.Forms.ComboBox();
            this.tb_stdfname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_stdlname = new System.Windows.Forms.TextBox();
            this.bt_addsubject = new System.Windows.Forms.Button();
            this.cb_classname = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(949, 458);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 36);
            this.panel1.TabIndex = 21;
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
            // cb_subjname
            // 
            this.cb_subjname.FormattingEnabled = true;
            this.cb_subjname.Location = new System.Drawing.Point(760, 528);
            this.cb_subjname.Name = "cb_subjname";
            this.cb_subjname.Size = new System.Drawing.Size(151, 28);
            this.cb_subjname.TabIndex = 22;
            // 
            // tb_stdfname
            // 
            this.tb_stdfname.Location = new System.Drawing.Point(172, 529);
            this.tb_stdfname.Name = "tb_stdfname";
            this.tb_stdfname.Size = new System.Drawing.Size(125, 27);
            this.tb_stdfname.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "First Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(321, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Class Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(619, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Subject Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(30, 581);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Last Name :";
            // 
            // tb_stdlname
            // 
            this.tb_stdlname.Location = new System.Drawing.Point(172, 578);
            this.tb_stdlname.Name = "tb_stdlname";
            this.tb_stdlname.Size = new System.Drawing.Size(125, 27);
            this.tb_stdlname.TabIndex = 29;
            // 
            // bt_addsubject
            // 
            this.bt_addsubject.Location = new System.Drawing.Point(581, 626);
            this.bt_addsubject.Name = "bt_addsubject";
            this.bt_addsubject.Size = new System.Drawing.Size(94, 29);
            this.bt_addsubject.TabIndex = 30;
            this.bt_addsubject.Text = "Add";
            this.bt_addsubject.UseVisualStyleBackColor = true;
            this.bt_addsubject.Click += new System.EventHandler(this.bt_addsubject_Click);
            // 
            // cb_classname
            // 
            this.cb_classname.FormattingEnabled = true;
            this.cb_classname.Location = new System.Drawing.Point(443, 529);
            this.cb_classname.Name = "cb_classname";
            this.cb_classname.Size = new System.Drawing.Size(151, 28);
            this.cb_classname.TabIndex = 31;
            // 
            // frmAddSubjForStd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 667);
            this.Controls.Add(this.cb_classname);
            this.Controls.Add(this.bt_addsubject);
            this.Controls.Add(this.tb_stdlname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_stdfname);
            this.Controls.Add(this.cb_subjname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(976, 714);
            this.MinimumSize = new System.Drawing.Size(976, 714);
            this.Name = "frmAddSubjForStd";
            this.Text = "frmAddSubjForStd";
            this.Load += new System.EventHandler(this.frmAddSubjForStd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_subjname;
        private System.Windows.Forms.TextBox tb_stdfname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_stdlname;
        private System.Windows.Forms.Button bt_addsubject;
        private System.Windows.Forms.ComboBox cb_classname;
    }
}