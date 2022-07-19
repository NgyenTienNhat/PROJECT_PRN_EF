namespace StudentManagement
{
    partial class frmManageClass
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_update_class = new System.Windows.Forms.Button();
            this.button_add_class = new System.Windows.Forms.Button();
            this.textBox_classname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_classid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 36);
            this.panel1.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(0, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 24);
            this.label12.TabIndex = 54;
            this.label12.Text = "MANAGE CLASS";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(388, -92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 28);
            this.label10.TabIndex = 1;
            this.label10.Text = "MANAGE CLASS";
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
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(464, 628);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_update_class);
            this.panel2.Controls.Add(this.button_add_class);
            this.panel2.Controls.Add(this.textBox_classname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox_classid);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(481, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 628);
            this.panel2.TabIndex = 21;
            // 
            // button_update_class
            // 
            this.button_update_class.BackColor = System.Drawing.SystemColors.Control;
            this.button_update_class.Location = new System.Drawing.Point(262, 585);
            this.button_update_class.Name = "button_update_class";
            this.button_update_class.Size = new System.Drawing.Size(160, 39);
            this.button_update_class.TabIndex = 40;
            this.button_update_class.Text = "Update";
            this.button_update_class.UseVisualStyleBackColor = false;
            this.button_update_class.Click += new System.EventHandler(this.button_update_class_Click);
            // 
            // button_add_class
            // 
            this.button_add_class.BackColor = System.Drawing.SystemColors.Control;
            this.button_add_class.Location = new System.Drawing.Point(39, 585);
            this.button_add_class.Name = "button_add_class";
            this.button_add_class.Size = new System.Drawing.Size(160, 39);
            this.button_add_class.TabIndex = 39;
            this.button_add_class.Text = "Add";
            this.button_add_class.UseVisualStyleBackColor = false;
            this.button_add_class.Click += new System.EventHandler(this.button_add_class_Click);
            // 
            // textBox_classname
            // 
            this.textBox_classname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_classname.Location = new System.Drawing.Point(173, 104);
            this.textBox_classname.Name = "textBox_classname";
            this.textBox_classname.PlaceholderText = "Enter ClassName";
            this.textBox_classname.Size = new System.Drawing.Size(168, 32);
            this.textBox_classname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(39, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class Name :";
            // 
            // textBox_classid
            // 
            this.textBox_classid.Enabled = false;
            this.textBox_classid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_classid.Location = new System.Drawing.Point(173, 39);
            this.textBox_classid.Name = "textBox_classid";
            this.textBox_classid.Size = new System.Drawing.Size(168, 32);
            this.textBox_classid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class ID :";
            // 
            // frmManageClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 694);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageClass";
            this.Text = "frmManageClass";
            this.Load += new System.EventHandler(this.frmManageClass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_classid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_classname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_add_class;
        private System.Windows.Forms.Button button_update_class;
        private System.Windows.Forms.Label label12;
    }
}