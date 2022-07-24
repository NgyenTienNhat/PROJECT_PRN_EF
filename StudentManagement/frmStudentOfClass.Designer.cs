namespace StudentManagement
{
    partial class frmStudentOfClass
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
            this.tb_totalstdofclass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_countfemale = new System.Windows.Forms.TextBox();
            this.textBox_countmale = new System.Windows.Forms.TextBox();
            this.button_filter = new System.Windows.Forms.Button();
            this.comboBox_classname = new System.Windows.Forms.ComboBox();
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
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 45);
            this.panel1.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(0, 15);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(303, 29);
            this.label12.TabIndex = 55;
            this.label12.Text = "MANAGE STUDENT OF CLASS";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(461, -115);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 35);
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
            this.label7.Location = new System.Drawing.Point(442, -156);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 35);
            this.label7.TabIndex = 0;
            this.label7.Text = "ADD NEW STUDENT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1192, 702);
            this.dataGridView1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tb_totalstdofclass);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox_countfemale);
            this.panel2.Controls.Add(this.textBox_countmale);
            this.panel2.Controls.Add(this.button_filter);
            this.panel2.Controls.Add(this.comboBox_classname);
            this.panel2.Location = new System.Drawing.Point(12, 768);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1192, 86);
            this.panel2.TabIndex = 21;
            // 
            // tb_totalstdofclass
            // 
            this.tb_totalstdofclass.Location = new System.Drawing.Point(612, 35);
            this.tb_totalstdofclass.Margin = new System.Windows.Forms.Padding(2);
            this.tb_totalstdofclass.Name = "tb_totalstdofclass";
            this.tb_totalstdofclass.Size = new System.Drawing.Size(96, 31);
            this.tb_totalstdofclass.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(508, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(269, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Female :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Male :";
            // 
            // textBox_countfemale
            // 
            this.textBox_countfemale.Location = new System.Drawing.Point(374, 31);
            this.textBox_countfemale.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_countfemale.Name = "textBox_countfemale";
            this.textBox_countfemale.Size = new System.Drawing.Size(96, 31);
            this.textBox_countfemale.TabIndex = 3;
            // 
            // textBox_countmale
            // 
            this.textBox_countmale.Location = new System.Drawing.Point(134, 31);
            this.textBox_countmale.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_countmale.Name = "textBox_countmale";
            this.textBox_countmale.Size = new System.Drawing.Size(96, 31);
            this.textBox_countmale.TabIndex = 2;
            // 
            // button_filter
            // 
            this.button_filter.Location = new System.Drawing.Point(1015, 31);
            this.button_filter.Margin = new System.Windows.Forms.Padding(2);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(112, 32);
            this.button_filter.TabIndex = 1;
            this.button_filter.Text = "Filter";
            this.button_filter.UseVisualStyleBackColor = true;
            this.button_filter.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // comboBox_classname
            // 
            this.comboBox_classname.FormattingEnabled = true;
            this.comboBox_classname.Location = new System.Drawing.Point(774, 32);
            this.comboBox_classname.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_classname.Name = "comboBox_classname";
            this.comboBox_classname.Size = new System.Drawing.Size(196, 33);
            this.comboBox_classname.TabIndex = 0;
            // 
            // frmStudentOfClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 868);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1212, 868);
            this.Name = "frmStudentOfClass";
            this.Text = "frmStudentOfClass";
            this.Load += new System.EventHandler(this.frmStudentOfClass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.ComboBox comboBox_classname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_countfemale;
        private System.Windows.Forms.TextBox textBox_countmale;
        private System.Windows.Forms.TextBox tb_totalstdofclass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
    }
}