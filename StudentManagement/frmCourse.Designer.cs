namespace StudentManagement
{
    partial class frmCourse
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
            this.panel_course = new System.Windows.Forms.Panel();
            this.button_list = new System.Windows.Forms.Button();
            this.button_view = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel_course
            // 
            this.panel_course.Location = new System.Drawing.Point(2, 39);
            this.panel_course.Name = "panel_course";
            this.panel_course.Size = new System.Drawing.Size(973, 675);
            this.panel_course.TabIndex = 0;
            this.panel_course.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button_list
            // 
            this.button_list.Location = new System.Drawing.Point(756, 5);
            this.button_list.Name = "button_list";
            this.button_list.Size = new System.Drawing.Size(102, 28);
            this.button_list.TabIndex = 1;
            this.button_list.Text = "List";
            this.button_list.UseVisualStyleBackColor = true;
            this.button_list.Click += new System.EventHandler(this.button_list_Click);
            // 
            // button_view
            // 
            this.button_view.Location = new System.Drawing.Point(864, 5);
            this.button_view.Name = "button_view";
            this.button_view.Size = new System.Drawing.Size(100, 28);
            this.button_view.TabIndex = 2;
            this.button_view.Text = "View Details";
            this.button_view.UseVisualStyleBackColor = true;
            this.button_view.Click += new System.EventHandler(this.button_view_Click);
            // 
            // frmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 714);
            this.Controls.Add(this.button_view);
            this.Controls.Add(this.button_list);
            this.Controls.Add(this.panel_course);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(976, 714);
            this.MinimumSize = new System.Drawing.Size(976, 714);
            this.Name = "frmCourse";
            this.Text = "frmCourse";
            this.Load += new System.EventHandler(this.frmCourse_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_course;
        private System.Windows.Forms.Button button_list;
        private System.Windows.Forms.Button button_view;
    }
}