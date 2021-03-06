﻿namespace Attendance_List
{
    partial class ParticipantDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParticipantDetails));
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LstBoxCourses = new System.Windows.Forms.ListBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.LblAdress = new System.Windows.Forms.Label();
            this.TxtAdress = new System.Windows.Forms.TextBox();
            this.LblBirthday = new System.Windows.Forms.Label();
            this.DTPDayOfBirth = new System.Windows.Forms.DateTimePicker();
            this.LblBadge = new System.Windows.Forms.Label();
            this.TxtBadge = new System.Windows.Forms.TextBox();
            this.LblCourses = new System.Windows.Forms.Label();
            this.LstTimeRegistrations = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(14, 20);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(49, 17);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(95, 20);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(241, 22);
            this.TxtName.TabIndex = 1;
            // 
            // LstBoxCourses
            // 
            this.LstBoxCourses.FormattingEnabled = true;
            this.LstBoxCourses.ItemHeight = 16;
            this.LstBoxCourses.Location = new System.Drawing.Point(95, 129);
            this.LstBoxCourses.Name = "LstBoxCourses";
            this.LstBoxCourses.Size = new System.Drawing.Size(327, 260);
            this.LstBoxCourses.TabIndex = 2;
            this.LstBoxCourses.SelectedIndexChanged += new System.EventHandler(this.LstBoxCourses_SelectedIndexChanged);
            this.LstBoxCourses.DoubleClick += new System.EventHandler(this.LstBoxCourses_DoubleClick);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(480, 472);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(131, 56);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(665, 474);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(131, 54);
            this.BtnQuit.TabIndex = 4;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // LblAdress
            // 
            this.LblAdress.AutoSize = true;
            this.LblAdress.Location = new System.Drawing.Point(12, 70);
            this.LblAdress.Name = "LblAdress";
            this.LblAdress.Size = new System.Drawing.Size(56, 17);
            this.LblAdress.TabIndex = 5;
            this.LblAdress.Text = "Adress:";
            // 
            // TxtAdress
            // 
            this.TxtAdress.Location = new System.Drawing.Point(95, 67);
            this.TxtAdress.Name = "TxtAdress";
            this.TxtAdress.Size = new System.Drawing.Size(241, 22);
            this.TxtAdress.TabIndex = 6;
            // 
            // LblBirthday
            // 
            this.LblBirthday.AutoSize = true;
            this.LblBirthday.Location = new System.Drawing.Point(12, 462);
            this.LblBirthday.Name = "LblBirthday";
            this.LblBirthday.Size = new System.Drawing.Size(85, 17);
            this.LblBirthday.TabIndex = 7;
            this.LblBirthday.Text = "Day of birth:";
            // 
            // DTPDayOfBirth
            // 
            this.DTPDayOfBirth.Location = new System.Drawing.Point(12, 505);
            this.DTPDayOfBirth.Name = "DTPDayOfBirth";
            this.DTPDayOfBirth.Size = new System.Drawing.Size(290, 22);
            this.DTPDayOfBirth.TabIndex = 8;
            // 
            // LblBadge
            // 
            this.LblBadge.AutoSize = true;
            this.LblBadge.Location = new System.Drawing.Point(12, 424);
            this.LblBadge.Name = "LblBadge";
            this.LblBadge.Size = new System.Drawing.Size(105, 17);
            this.LblBadge.TabIndex = 9;
            this.LblBadge.Text = "Badge number:";
            // 
            // TxtBadge
            // 
            this.TxtBadge.Location = new System.Drawing.Point(145, 421);
            this.TxtBadge.Name = "TxtBadge";
            this.TxtBadge.Size = new System.Drawing.Size(191, 22);
            this.TxtBadge.TabIndex = 10;
            // 
            // LblCourses
            // 
            this.LblCourses.AutoSize = true;
            this.LblCourses.Location = new System.Drawing.Point(12, 129);
            this.LblCourses.Name = "LblCourses";
            this.LblCourses.Size = new System.Drawing.Size(64, 17);
            this.LblCourses.TabIndex = 11;
            this.LblCourses.Text = "Courses:";
            // 
            // LstTimeRegistrations
            // 
            this.LstTimeRegistrations.FormattingEnabled = true;
            this.LstTimeRegistrations.ItemHeight = 16;
            this.LstTimeRegistrations.Location = new System.Drawing.Point(480, 129);
            this.LstTimeRegistrations.Name = "LstTimeRegistrations";
            this.LstTimeRegistrations.Size = new System.Drawing.Size(316, 324);
            this.LstTimeRegistrations.TabIndex = 12;
            this.LstTimeRegistrations.DoubleClick += new System.EventHandler(this.LstTimeRegistrations_DoubleClick);
            // 
            // ParticipantDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 539);
            this.Controls.Add(this.LstTimeRegistrations);
            this.Controls.Add(this.LblCourses);
            this.Controls.Add(this.TxtBadge);
            this.Controls.Add(this.LblBadge);
            this.Controls.Add(this.DTPDayOfBirth);
            this.Controls.Add(this.LblBirthday);
            this.Controls.Add(this.TxtAdress);
            this.Controls.Add(this.LblAdress);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LstBoxCourses);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(756, 517);
            this.Name = "ParticipantDetails";
            this.Text = "ParticipantDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParticipantDetails_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ParticipantDetails_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.ListBox LstBoxCourses;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.Label LblAdress;
        private System.Windows.Forms.TextBox TxtAdress;
        private System.Windows.Forms.Label LblBirthday;
        private System.Windows.Forms.DateTimePicker DTPDayOfBirth;
        private System.Windows.Forms.Label LblBadge;
        private System.Windows.Forms.TextBox TxtBadge;
        private System.Windows.Forms.Label LblCourses;
        private System.Windows.Forms.ListBox LstTimeRegistrations;
    }
}