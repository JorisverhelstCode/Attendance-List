namespace Attendance_List
{
    partial class TeacherDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherDetails));
            this.LblCompany = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblCourses = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtCompany = new System.Windows.Forms.TextBox();
            this.LstCourses = new System.Windows.Forms.ListBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblCompany
            // 
            this.LblCompany.AutoSize = true;
            this.LblCompany.Location = new System.Drawing.Point(21, 67);
            this.LblCompany.Name = "LblCompany";
            this.LblCompany.Size = new System.Drawing.Size(71, 17);
            this.LblCompany.TabIndex = 0;
            this.LblCompany.Text = "Company:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(21, 20);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(49, 17);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Name:";
            // 
            // LblCourses
            // 
            this.LblCourses.AutoSize = true;
            this.LblCourses.Location = new System.Drawing.Point(21, 110);
            this.LblCourses.Name = "LblCourses";
            this.LblCourses.Size = new System.Drawing.Size(64, 17);
            this.LblCourses.TabIndex = 2;
            this.LblCourses.Text = "Courses:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(117, 20);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(237, 22);
            this.TxtName.TabIndex = 3;
            // 
            // TxtCompany
            // 
            this.TxtCompany.Location = new System.Drawing.Point(117, 67);
            this.TxtCompany.Name = "TxtCompany";
            this.TxtCompany.Size = new System.Drawing.Size(237, 22);
            this.TxtCompany.TabIndex = 4;
            // 
            // LstCourses
            // 
            this.LstCourses.FormattingEnabled = true;
            this.LstCourses.ItemHeight = 16;
            this.LstCourses.Location = new System.Drawing.Point(24, 153);
            this.LstCourses.Name = "LstCourses";
            this.LstCourses.Size = new System.Drawing.Size(329, 212);
            this.LstCourses.TabIndex = 5;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(24, 386);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(128, 52);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(224, 386);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(129, 51);
            this.BtnQuit.TabIndex = 7;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // TeacherDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LstCourses);
            this.Controls.Add(this.TxtCompany);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblCourses);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblCompany);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeacherDetails";
            this.Text = "TeacherDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeacherDetails_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherDetails_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCompany;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblCourses;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtCompany;
        private System.Windows.Forms.ListBox LstCourses;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnQuit;
    }
}