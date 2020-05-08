namespace TimeRegistartion
{
    partial class BadgeIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BadgeIn));
            this.LstParticipants = new System.Windows.Forms.ListBox();
            this.LblCourse = new System.Windows.Forms.Label();
            this.LblCourseName = new System.Windows.Forms.Label();
            this.LblToday = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnBadgeIn = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstParticipants
            // 
            this.LstParticipants.FormattingEnabled = true;
            this.LstParticipants.ItemHeight = 16;
            this.LstParticipants.Location = new System.Drawing.Point(37, 65);
            this.LstParticipants.Name = "LstParticipants";
            this.LstParticipants.Size = new System.Drawing.Size(277, 260);
            this.LstParticipants.TabIndex = 0;
            // 
            // LblCourse
            // 
            this.LblCourse.AutoSize = true;
            this.LblCourse.Location = new System.Drawing.Point(34, 27);
            this.LblCourse.Name = "LblCourse";
            this.LblCourse.Size = new System.Drawing.Size(57, 17);
            this.LblCourse.TabIndex = 1;
            this.LblCourse.Text = "Course:";
            // 
            // LblCourseName
            // 
            this.LblCourseName.AutoSize = true;
            this.LblCourseName.Location = new System.Drawing.Point(124, 27);
            this.LblCourseName.Name = "LblCourseName";
            this.LblCourseName.Size = new System.Drawing.Size(116, 17);
            this.LblCourseName.TabIndex = 2;
            this.LblCourseName.Text = "Unnamed course";
            // 
            // LblToday
            // 
            this.LblToday.AutoSize = true;
            this.LblToday.Location = new System.Drawing.Point(360, 27);
            this.LblToday.Name = "LblToday";
            this.LblToday.Size = new System.Drawing.Size(144, 17);
            this.LblToday.TabIndex = 3;
            this.LblToday.Text = "Today\'s registartions:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(363, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(347, 260);
            this.listBox1.TabIndex = 4;
            // 
            // BtnBadgeIn
            // 
            this.BtnBadgeIn.Location = new System.Drawing.Point(37, 354);
            this.BtnBadgeIn.Name = "BtnBadgeIn";
            this.BtnBadgeIn.Size = new System.Drawing.Size(277, 56);
            this.BtnBadgeIn.TabIndex = 5;
            this.BtnBadgeIn.Text = "Badge";
            this.BtnBadgeIn.UseVisualStyleBackColor = true;
            this.BtnBadgeIn.Click += new System.EventHandler(this.BtnBadgeIn_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(583, 354);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(127, 56);
            this.BtnQuit.TabIndex = 6;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // BadgeIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 423);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnBadgeIn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.LblToday);
            this.Controls.Add(this.LblCourseName);
            this.Controls.Add(this.LblCourse);
            this.Controls.Add(this.LstParticipants);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(752, 470);
            this.MinimumSize = new System.Drawing.Size(752, 470);
            this.Name = "BadgeIn";
            this.Text = "BadgeIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstParticipants;
        private System.Windows.Forms.Label LblCourse;
        private System.Windows.Forms.Label LblCourseName;
        private System.Windows.Forms.Label LblToday;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnBadgeIn;
        private System.Windows.Forms.Button BtnQuit;
    }
}