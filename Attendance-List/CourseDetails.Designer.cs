namespace Attendance_List
{
    partial class CourseDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseDetails));
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LstParticipants = new System.Windows.Forms.ListBox();
            this.LstTeachers = new System.Windows.Forms.ListBox();
            this.LblParticipants = new System.Windows.Forms.Label();
            this.LblTeachers = new System.Windows.Forms.Label();
            this.BtnAddParticipant = new System.Windows.Forms.Button();
            this.BtnRemoveParticipant = new System.Windows.Forms.Button();
            this.LblInstitution = new System.Windows.Forms.Label();
            this.txtInstitution = new System.Windows.Forms.TextBox();
            this.TxtContactPerson = new System.Windows.Forms.TextBox();
            this.LblContactPerson = new System.Windows.Forms.Label();
            this.LblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.LblOeNumber = new System.Windows.Forms.Label();
            this.LblCourseCode = new System.Windows.Forms.Label();
            this.TxtOeNumber = new System.Windows.Forms.TextBox();
            this.TxtCourseCode = new System.Windows.Forms.TextBox();
            this.BtnAddTeacher = new System.Windows.Forms.Button();
            this.BtnRemoveTeacher = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.DTPStartDate = new System.Windows.Forms.DateTimePicker();
            this.DTPEndDate = new System.Windows.Forms.DateTimePicker();
            this.LblStartDate = new System.Windows.Forms.Label();
            this.LblEndDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(16, 58);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(320, 22);
            this.TxtName.TabIndex = 0;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(13, 20);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(49, 17);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Name:";
            // 
            // LstParticipants
            // 
            this.LstParticipants.FormattingEnabled = true;
            this.LstParticipants.ItemHeight = 16;
            this.LstParticipants.Location = new System.Drawing.Point(375, 71);
            this.LstParticipants.Name = "LstParticipants";
            this.LstParticipants.Size = new System.Drawing.Size(278, 356);
            this.LstParticipants.TabIndex = 2;
            // 
            // LstTeachers
            // 
            this.LstTeachers.FormattingEnabled = true;
            this.LstTeachers.ItemHeight = 16;
            this.LstTeachers.Location = new System.Drawing.Point(737, 58);
            this.LstTeachers.Name = "LstTeachers";
            this.LstTeachers.Size = new System.Drawing.Size(279, 228);
            this.LstTeachers.TabIndex = 3;
            // 
            // LblParticipants
            // 
            this.LblParticipants.AutoSize = true;
            this.LblParticipants.Location = new System.Drawing.Point(375, 23);
            this.LblParticipants.Name = "LblParticipants";
            this.LblParticipants.Size = new System.Drawing.Size(86, 17);
            this.LblParticipants.TabIndex = 4;
            this.LblParticipants.Text = "Particpiants:";
            // 
            // LblTeachers
            // 
            this.LblTeachers.AutoSize = true;
            this.LblTeachers.Location = new System.Drawing.Point(734, 23);
            this.LblTeachers.Name = "LblTeachers";
            this.LblTeachers.Size = new System.Drawing.Size(72, 17);
            this.LblTeachers.TabIndex = 5;
            this.LblTeachers.Text = "Teachers:";
            // 
            // BtnAddParticipant
            // 
            this.BtnAddParticipant.Location = new System.Drawing.Point(378, 433);
            this.BtnAddParticipant.Name = "BtnAddParticipant";
            this.BtnAddParticipant.Size = new System.Drawing.Size(121, 62);
            this.BtnAddParticipant.TabIndex = 6;
            this.BtnAddParticipant.Text = "Add";
            this.BtnAddParticipant.UseVisualStyleBackColor = true;
            this.BtnAddParticipant.Click += new System.EventHandler(this.BtnAddParticipant_Click);
            // 
            // BtnRemoveParticipant
            // 
            this.BtnRemoveParticipant.Location = new System.Drawing.Point(532, 433);
            this.BtnRemoveParticipant.Name = "BtnRemoveParticipant";
            this.BtnRemoveParticipant.Size = new System.Drawing.Size(121, 62);
            this.BtnRemoveParticipant.TabIndex = 7;
            this.BtnRemoveParticipant.Text = "Remove";
            this.BtnRemoveParticipant.UseVisualStyleBackColor = true;
            this.BtnRemoveParticipant.Click += new System.EventHandler(this.BtnRemoveParticipant_Click);
            // 
            // LblInstitution
            // 
            this.LblInstitution.AutoSize = true;
            this.LblInstitution.Location = new System.Drawing.Point(13, 103);
            this.LblInstitution.Name = "LblInstitution";
            this.LblInstitution.Size = new System.Drawing.Size(72, 17);
            this.LblInstitution.TabIndex = 8;
            this.LblInstitution.Text = "Institution:";
            // 
            // txtInstitution
            // 
            this.txtInstitution.Location = new System.Drawing.Point(16, 142);
            this.txtInstitution.Name = "txtInstitution";
            this.txtInstitution.Size = new System.Drawing.Size(320, 22);
            this.txtInstitution.TabIndex = 9;
            // 
            // TxtContactPerson
            // 
            this.TxtContactPerson.Location = new System.Drawing.Point(16, 221);
            this.TxtContactPerson.Name = "TxtContactPerson";
            this.TxtContactPerson.Size = new System.Drawing.Size(320, 22);
            this.TxtContactPerson.TabIndex = 10;
            // 
            // LblContactPerson
            // 
            this.LblContactPerson.AutoSize = true;
            this.LblContactPerson.Location = new System.Drawing.Point(11, 185);
            this.LblContactPerson.Name = "LblContactPerson";
            this.LblContactPerson.Size = new System.Drawing.Size(109, 17);
            this.LblContactPerson.TabIndex = 11;
            this.LblContactPerson.Text = "Contact Person:";
            // 
            // LblLocation
            // 
            this.LblLocation.AutoSize = true;
            this.LblLocation.Location = new System.Drawing.Point(11, 265);
            this.LblLocation.Name = "LblLocation";
            this.LblLocation.Size = new System.Drawing.Size(66, 17);
            this.LblLocation.TabIndex = 12;
            this.LblLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(14, 305);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(322, 22);
            this.txtLocation.TabIndex = 13;
            // 
            // LblOeNumber
            // 
            this.LblOeNumber.AutoSize = true;
            this.LblOeNumber.Location = new System.Drawing.Point(11, 352);
            this.LblOeNumber.Name = "LblOeNumber";
            this.LblOeNumber.Size = new System.Drawing.Size(81, 17);
            this.LblOeNumber.TabIndex = 14;
            this.LblOeNumber.Text = "OeNumber:";
            // 
            // LblCourseCode
            // 
            this.LblCourseCode.AutoSize = true;
            this.LblCourseCode.Location = new System.Drawing.Point(13, 397);
            this.LblCourseCode.Name = "LblCourseCode";
            this.LblCourseCode.Size = new System.Drawing.Size(94, 17);
            this.LblCourseCode.TabIndex = 15;
            this.LblCourseCode.Text = "Course Code:";
            // 
            // TxtOeNumber
            // 
            this.TxtOeNumber.Location = new System.Drawing.Point(140, 352);
            this.TxtOeNumber.Name = "TxtOeNumber";
            this.TxtOeNumber.Size = new System.Drawing.Size(196, 22);
            this.TxtOeNumber.TabIndex = 16;
            // 
            // TxtCourseCode
            // 
            this.TxtCourseCode.Location = new System.Drawing.Point(140, 397);
            this.TxtCourseCode.Name = "TxtCourseCode";
            this.TxtCourseCode.Size = new System.Drawing.Size(196, 22);
            this.TxtCourseCode.TabIndex = 17;
            // 
            // BtnAddTeacher
            // 
            this.BtnAddTeacher.Location = new System.Drawing.Point(736, 309);
            this.BtnAddTeacher.Name = "BtnAddTeacher";
            this.BtnAddTeacher.Size = new System.Drawing.Size(133, 65);
            this.BtnAddTeacher.TabIndex = 18;
            this.BtnAddTeacher.Text = "Add";
            this.BtnAddTeacher.UseVisualStyleBackColor = true;
            this.BtnAddTeacher.Click += new System.EventHandler(this.BtnAddTeacher_Click);
            // 
            // BtnRemoveTeacher
            // 
            this.BtnRemoveTeacher.Location = new System.Drawing.Point(900, 310);
            this.BtnRemoveTeacher.Name = "BtnRemoveTeacher";
            this.BtnRemoveTeacher.Size = new System.Drawing.Size(115, 64);
            this.BtnRemoveTeacher.TabIndex = 19;
            this.BtnRemoveTeacher.Text = "Remove";
            this.BtnRemoveTeacher.UseVisualStyleBackColor = true;
            this.BtnRemoveTeacher.Click += new System.EventHandler(this.BtnRemoveTeacher_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(740, 433);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(129, 61);
            this.BtnSave.TabIndex = 20;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(900, 433);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(115, 60);
            this.BtnQuit.TabIndex = 21;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // DTPStartDate
            // 
            this.DTPStartDate.Location = new System.Drawing.Point(140, 433);
            this.DTPStartDate.Name = "DTPStartDate";
            this.DTPStartDate.Size = new System.Drawing.Size(200, 22);
            this.DTPStartDate.TabIndex = 22;
            // 
            // DTPEndDate
            // 
            this.DTPEndDate.Location = new System.Drawing.Point(140, 473);
            this.DTPEndDate.Name = "DTPEndDate";
            this.DTPEndDate.Size = new System.Drawing.Size(200, 22);
            this.DTPEndDate.TabIndex = 23;
            // 
            // LblStartDate
            // 
            this.LblStartDate.AutoSize = true;
            this.LblStartDate.Location = new System.Drawing.Point(13, 438);
            this.LblStartDate.Name = "LblStartDate";
            this.LblStartDate.Size = new System.Drawing.Size(76, 17);
            this.LblStartDate.TabIndex = 24;
            this.LblStartDate.Text = "Start Date:";
            // 
            // LblEndDate
            // 
            this.LblEndDate.AutoSize = true;
            this.LblEndDate.Location = new System.Drawing.Point(13, 478);
            this.LblEndDate.Name = "LblEndDate";
            this.LblEndDate.Size = new System.Drawing.Size(71, 17);
            this.LblEndDate.TabIndex = 25;
            this.LblEndDate.Text = "End Date:";
            // 
            // CourseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 524);
            this.Controls.Add(this.LblEndDate);
            this.Controls.Add(this.LblStartDate);
            this.Controls.Add(this.DTPEndDate);
            this.Controls.Add(this.DTPStartDate);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnRemoveTeacher);
            this.Controls.Add(this.BtnAddTeacher);
            this.Controls.Add(this.TxtCourseCode);
            this.Controls.Add(this.TxtOeNumber);
            this.Controls.Add(this.LblCourseCode);
            this.Controls.Add(this.LblOeNumber);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.LblLocation);
            this.Controls.Add(this.LblContactPerson);
            this.Controls.Add(this.TxtContactPerson);
            this.Controls.Add(this.txtInstitution);
            this.Controls.Add(this.LblInstitution);
            this.Controls.Add(this.BtnRemoveParticipant);
            this.Controls.Add(this.BtnAddParticipant);
            this.Controls.Add(this.LblTeachers);
            this.Controls.Add(this.LblParticipants);
            this.Controls.Add(this.LstTeachers);
            this.Controls.Add(this.LstParticipants);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1058, 571);
            this.MinimumSize = new System.Drawing.Size(1058, 571);
            this.Name = "CourseDetails";
            this.Text = "CourseDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.ListBox LstParticipants;
        private System.Windows.Forms.ListBox LstTeachers;
        private System.Windows.Forms.Label LblParticipants;
        private System.Windows.Forms.Label LblTeachers;
        private System.Windows.Forms.Button BtnAddParticipant;
        private System.Windows.Forms.Button BtnRemoveParticipant;
        private System.Windows.Forms.Label LblInstitution;
        private System.Windows.Forms.TextBox txtInstitution;
        private System.Windows.Forms.TextBox TxtContactPerson;
        private System.Windows.Forms.Label LblContactPerson;
        private System.Windows.Forms.Label LblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label LblOeNumber;
        private System.Windows.Forms.Label LblCourseCode;
        private System.Windows.Forms.TextBox TxtOeNumber;
        private System.Windows.Forms.TextBox TxtCourseCode;
        private System.Windows.Forms.Button BtnAddTeacher;
        private System.Windows.Forms.Button BtnRemoveTeacher;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.DateTimePicker DTPStartDate;
        private System.Windows.Forms.DateTimePicker DTPEndDate;
        private System.Windows.Forms.Label LblStartDate;
        private System.Windows.Forms.Label LblEndDate;
    }
}