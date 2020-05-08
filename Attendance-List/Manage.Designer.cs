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
            this.BtnCreateCourse = new System.Windows.Forms.Button();
            this.BtnDeleteCourse = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.LstParticipants = new System.Windows.Forms.ListBox();
            this.LblCourses = new System.Windows.Forms.Label();
            this.LblParticipants = new System.Windows.Forms.Label();
            this.LstTeachers = new System.Windows.Forms.ListBox();
            this.LblTeachers = new System.Windows.Forms.Label();
            this.BtnCreateNewParticipant = new System.Windows.Forms.Button();
            this.BtnDeleteParticipant = new System.Windows.Forms.Button();
            this.BtnCreateNewTeacher = new System.Windows.Forms.Button();
            this.BtnDeleteTeacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstBoxCourses
            // 
            this.LstBoxCourses.FormattingEnabled = true;
            this.LstBoxCourses.ItemHeight = 16;
            this.LstBoxCourses.Location = new System.Drawing.Point(18, 58);
            this.LstBoxCourses.Name = "LstBoxCourses";
            this.LstBoxCourses.Size = new System.Drawing.Size(292, 356);
            this.LstBoxCourses.TabIndex = 0;
            this.LstBoxCourses.DoubleClick += new System.EventHandler(this.LstBoxCourses_DoubleClick);
            // 
            // BtnCreateCourse
            // 
            this.BtnCreateCourse.Location = new System.Drawing.Point(18, 437);
            this.BtnCreateCourse.Name = "BtnCreateCourse";
            this.BtnCreateCourse.Size = new System.Drawing.Size(128, 65);
            this.BtnCreateCourse.TabIndex = 2;
            this.BtnCreateCourse.Text = "Create new Course";
            this.BtnCreateCourse.UseVisualStyleBackColor = true;
            this.BtnCreateCourse.Click += new System.EventHandler(this.BtnCreateCourse_Click);
            // 
            // BtnDeleteCourse
            // 
            this.BtnDeleteCourse.Location = new System.Drawing.Point(186, 437);
            this.BtnDeleteCourse.Name = "BtnDeleteCourse";
            this.BtnDeleteCourse.Size = new System.Drawing.Size(128, 65);
            this.BtnDeleteCourse.TabIndex = 3;
            this.BtnDeleteCourse.Text = "Delete Course";
            this.BtnDeleteCourse.UseVisualStyleBackColor = true;
            this.BtnDeleteCourse.Click += new System.EventHandler(this.BtnDeleteCourse_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(992, 437);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(128, 65);
            this.BtnQuit.TabIndex = 4;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // LstParticipants
            // 
            this.LstParticipants.FormattingEnabled = true;
            this.LstParticipants.ItemHeight = 16;
            this.LstParticipants.Location = new System.Drawing.Point(345, 58);
            this.LstParticipants.Name = "LstParticipants";
            this.LstParticipants.Size = new System.Drawing.Size(292, 356);
            this.LstParticipants.TabIndex = 5;
            this.LstParticipants.DoubleClick += new System.EventHandler(this.LstParticipants_DoubleClick);
            // 
            // LblCourses
            // 
            this.LblCourses.AutoSize = true;
            this.LblCourses.Location = new System.Drawing.Point(19, 15);
            this.LblCourses.Name = "LblCourses";
            this.LblCourses.Size = new System.Drawing.Size(64, 17);
            this.LblCourses.TabIndex = 6;
            this.LblCourses.Text = "Courses:";
            // 
            // LblParticipants
            // 
            this.LblParticipants.AutoSize = true;
            this.LblParticipants.Location = new System.Drawing.Point(342, 15);
            this.LblParticipants.Name = "LblParticipants";
            this.LblParticipants.Size = new System.Drawing.Size(86, 17);
            this.LblParticipants.TabIndex = 7;
            this.LblParticipants.Text = "Participants:";
            // 
            // LstTeachers
            // 
            this.LstTeachers.FormattingEnabled = true;
            this.LstTeachers.ItemHeight = 16;
            this.LstTeachers.Location = new System.Drawing.Point(681, 58);
            this.LstTeachers.Name = "LstTeachers";
            this.LstTeachers.Size = new System.Drawing.Size(292, 356);
            this.LstTeachers.TabIndex = 8;
            this.LstTeachers.DoubleClick += new System.EventHandler(this.LstTeachers_DoubleClick);
            // 
            // LblTeachers
            // 
            this.LblTeachers.AutoSize = true;
            this.LblTeachers.Location = new System.Drawing.Point(678, 15);
            this.LblTeachers.Name = "LblTeachers";
            this.LblTeachers.Size = new System.Drawing.Size(72, 17);
            this.LblTeachers.TabIndex = 9;
            this.LblTeachers.Text = "Teachers:";
            // 
            // BtnCreateNewParticipant
            // 
            this.BtnCreateNewParticipant.Location = new System.Drawing.Point(345, 437);
            this.BtnCreateNewParticipant.Name = "BtnCreateNewParticipant";
            this.BtnCreateNewParticipant.Size = new System.Drawing.Size(128, 65);
            this.BtnCreateNewParticipant.TabIndex = 10;
            this.BtnCreateNewParticipant.Text = "Create new participant";
            this.BtnCreateNewParticipant.UseVisualStyleBackColor = true;
            this.BtnCreateNewParticipant.Click += new System.EventHandler(this.BtnCreateNewParticipant_Click);
            // 
            // BtnDeleteParticipant
            // 
            this.BtnDeleteParticipant.Location = new System.Drawing.Point(509, 437);
            this.BtnDeleteParticipant.Name = "BtnDeleteParticipant";
            this.BtnDeleteParticipant.Size = new System.Drawing.Size(128, 65);
            this.BtnDeleteParticipant.TabIndex = 11;
            this.BtnDeleteParticipant.Text = "Delete participant";
            this.BtnDeleteParticipant.UseVisualStyleBackColor = true;
            this.BtnDeleteParticipant.Click += new System.EventHandler(this.BtnDeleteParticipant_Click);
            // 
            // BtnCreateNewTeacher
            // 
            this.BtnCreateNewTeacher.Location = new System.Drawing.Point(681, 437);
            this.BtnCreateNewTeacher.Name = "BtnCreateNewTeacher";
            this.BtnCreateNewTeacher.Size = new System.Drawing.Size(128, 65);
            this.BtnCreateNewTeacher.TabIndex = 12;
            this.BtnCreateNewTeacher.Text = "Create new teacher";
            this.BtnCreateNewTeacher.UseVisualStyleBackColor = true;
            this.BtnCreateNewTeacher.Click += new System.EventHandler(this.BtnCreateNewTeacher_Click);
            // 
            // BtnDeleteTeacher
            // 
            this.BtnDeleteTeacher.Location = new System.Drawing.Point(845, 437);
            this.BtnDeleteTeacher.Name = "BtnDeleteTeacher";
            this.BtnDeleteTeacher.Size = new System.Drawing.Size(128, 65);
            this.BtnDeleteTeacher.TabIndex = 13;
            this.BtnDeleteTeacher.Text = "Delete teacher";
            this.BtnDeleteTeacher.UseVisualStyleBackColor = true;
            this.BtnDeleteTeacher.Click += new System.EventHandler(this.BtnDeleteTeacher_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 529);
            this.Controls.Add(this.BtnDeleteTeacher);
            this.Controls.Add(this.BtnCreateNewTeacher);
            this.Controls.Add(this.BtnDeleteParticipant);
            this.Controls.Add(this.BtnCreateNewParticipant);
            this.Controls.Add(this.LblTeachers);
            this.Controls.Add(this.LstTeachers);
            this.Controls.Add(this.LblParticipants);
            this.Controls.Add(this.LblCourses);
            this.Controls.Add(this.LstParticipants);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnDeleteCourse);
            this.Controls.Add(this.BtnCreateCourse);
            this.Controls.Add(this.LstBoxCourses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(808, 576);
            this.Name = "Manage";
            this.Text = "Manage Attendences";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manage_FormClosing);
            this.Load += new System.EventHandler(this.Manage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Manage_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.ListBox LstBoxCourses;
        private System.Windows.Forms.Button BtnCreateCourse;
        private System.Windows.Forms.Button BtnDeleteCourse;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.ListBox LstParticipants;
        private System.Windows.Forms.Label LblCourses;
        private System.Windows.Forms.Label LblParticipants;
        private System.Windows.Forms.ListBox LstTeachers;
        private System.Windows.Forms.Label LblTeachers;
        private System.Windows.Forms.Button BtnCreateNewParticipant;
        private System.Windows.Forms.Button BtnDeleteParticipant;
        private System.Windows.Forms.Button BtnCreateNewTeacher;
        private System.Windows.Forms.Button BtnDeleteTeacher;
    }
}

