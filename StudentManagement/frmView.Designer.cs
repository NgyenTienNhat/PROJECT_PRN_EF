namespace StudentManagement
{
    partial class frmView
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
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_stdid = new System.Windows.Forms.TextBox();
            this.tb_rollno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_classname = new System.Windows.Forms.ComboBox();
            this.tb_stdlname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_stdfname = new System.Windows.Forms.TextBox();
            this.cb_subjname = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(174, 589);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(125, 27);
            this.tb_id.TabIndex = 69;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_id.Location = new System.Drawing.Point(32, 589);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(37, 24);
            this.label_id.TabIndex = 68;
            this.label_id.Text = "ID :";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(823, 623);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(94, 29);
            this.button_delete.TabIndex = 67;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(709, 623);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(94, 29);
            this.button_update.TabIndex = 66;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(32, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 24);
            this.label6.TabIndex = 65;
            this.label6.Text = "StudentID :";
            // 
            // tb_stdid
            // 
            this.tb_stdid.Enabled = false;
            this.tb_stdid.Location = new System.Drawing.Point(174, 542);
            this.tb_stdid.Name = "tb_stdid";
            this.tb_stdid.Size = new System.Drawing.Size(125, 27);
            this.tb_stdid.TabIndex = 64;
            // 
            // tb_rollno
            // 
            this.tb_rollno.Enabled = false;
            this.tb_rollno.Location = new System.Drawing.Point(474, 542);
            this.tb_rollno.Name = "tb_rollno";
            this.tb_rollno.Size = new System.Drawing.Size(125, 27);
            this.tb_rollno.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(347, 545);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 62;
            this.label5.Text = "RollNo :";
            // 
            // cb_classname
            // 
            this.cb_classname.Enabled = false;
            this.cb_classname.FormattingEnabled = true;
            this.cb_classname.Location = new System.Drawing.Point(786, 493);
            this.cb_classname.Name = "cb_classname";
            this.cb_classname.Size = new System.Drawing.Size(131, 28);
            this.cb_classname.TabIndex = 61;
            // 
            // tb_stdlname
            // 
            this.tb_stdlname.Enabled = false;
            this.tb_stdlname.Location = new System.Drawing.Point(474, 490);
            this.tb_stdlname.Name = "tb_stdlname";
            this.tb_stdlname.Size = new System.Drawing.Size(125, 27);
            this.tb_stdlname.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(347, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 58;
            this.label4.Text = "Last Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(645, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 57;
            this.label3.Text = "Subject Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(643, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 56;
            this.label2.Text = "Class ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 55;
            this.label1.Text = "First Name :";
            // 
            // tb_stdfname
            // 
            this.tb_stdfname.Enabled = false;
            this.tb_stdfname.Location = new System.Drawing.Point(174, 493);
            this.tb_stdfname.Name = "tb_stdfname";
            this.tb_stdfname.Size = new System.Drawing.Size(125, 27);
            this.tb_stdfname.TabIndex = 54;
            // 
            // cb_subjname
            // 
            this.cb_subjname.FormattingEnabled = true;
            this.cb_subjname.Location = new System.Drawing.Point(786, 541);
            this.cb_subjname.Name = "cb_subjname";
            this.cb_subjname.Size = new System.Drawing.Size(131, 28);
            this.cb_subjname.TabIndex = 53;
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
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 714);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_stdid);
            this.Controls.Add(this.tb_rollno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_classname);
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
            this.Name = "frmView";
            this.Text = "frmView";
            this.Load += new System.EventHandler(this.frmView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_stdid;
        private System.Windows.Forms.TextBox tb_rollno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_classname;
        private System.Windows.Forms.TextBox tb_stdlname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_stdfname;
        private System.Windows.Forms.ComboBox cb_subjname;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}