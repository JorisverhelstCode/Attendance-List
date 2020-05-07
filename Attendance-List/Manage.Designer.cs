using System;

namespace Attendance_List
{
    partial class Manage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage));
            this.LstBoxCourses = new System.Windows.Forms.ListBox();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.BtnCreateCourse = new System.Windows.Forms.Button();
            this.BtnDeleteCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstBoxCourses
            // 
            this.LstBoxCourses.FormattingEnabled = true;
            this.LstBoxCourses.ItemHeight = 16;
            this.LstBoxCourses.Location = new System.Drawing.Point(18, 26);
            this.LstBoxCourses.Name = "LstBoxCourses";
            this.LstBoxCourses.Size = new System.Drawing.Size(319, 388);
            this.LstBoxCourses.TabIndex = 0;
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(18, 447);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(319, 55);
            this.BtnOpen.TabIndex = 1;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BtnCreateCourse
            // 
            this.BtnCreateCourse.Location = new System.Drawing.Point(374, 26);
            this.BtnCreateCourse.Name = "BtnCreateCourse";
            this.BtnCreateCourse.Size = new System.Drawing.Size(187, 65);
            this.BtnCreateCourse.TabIndex = 2;
            this.BtnCreateCourse.Text = "Create new Course";
            this.BtnCreateCourse.UseVisualStyleBackColor = true;
            this.BtnCreateCourse.Click += new System.EventHandler(this.BtnCreateCourse_Click);
            // 
            // BtnDeleteCourse
            // 
            this.BtnDeleteCourse.Location = new System.Drawing.Point(591, 26);
            this.BtnDeleteCourse.Name = "BtnDeleteCourse";
            this.BtnDeleteCourse.Size = new System.Drawing.Size(187, 65);
            this.BtnDeleteCourse.TabIndex = 3;
            this.BtnDeleteCourse.Text = "Delete Course";
            this.BtnDeleteCourse.UseVisualStyleBackColor = true;
            this.BtnDeleteCourse.Click += new System.EventHandler(this.BtnDeleteCourse_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 529);
            this.Controls.Add(this.BtnDeleteCourse);
            this.Controls.Add(this.BtnCreateCourse);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.LstBoxCourses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(808, 576);
            this.MinimumSize = new System.Drawing.Size(808, 576);
            this.Name = "Manage";
            this.Text = "Manage Attendences";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manage_FormClosing);
            this.Load += new System.EventHandler(this.Manage_Load);
            this.ResumeLayout(false);

        }

        private void Manage_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.ListBox LstBoxCourses;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button BtnCreateCourse;
        private System.Windows.Forms.Button BtnDeleteCourse;
    }
}

