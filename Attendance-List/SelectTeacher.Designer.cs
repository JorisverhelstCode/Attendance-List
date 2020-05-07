namespace Attendance_List
{
    partial class SelectTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectTeacher));
            this.LblAddingTo = new System.Windows.Forms.Label();
            this.LblCourseName = new System.Windows.Forms.Label();
            this.LblFilter = new System.Windows.Forms.Label();
            this.LstTeachers = new System.Windows.Forms.ListBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnCreateNewTeacher = new System.Windows.Forms.Button();
            this.TxtFilter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblAddingTo
            // 
            this.LblAddingTo.AutoSize = true;
            this.LblAddingTo.Location = new System.Drawing.Point(86, 18);
            this.LblAddingTo.Name = "LblAddingTo";
            this.LblAddingTo.Size = new System.Drawing.Size(72, 17);
            this.LblAddingTo.TabIndex = 0;
            this.LblAddingTo.Text = "Adding to:";
            // 
            // LblCourseName
            // 
            this.LblCourseName.AutoSize = true;
            this.LblCourseName.Location = new System.Drawing.Point(12, 68);
            this.LblCourseName.Name = "LblCourseName";
            this.LblCourseName.Size = new System.Drawing.Size(118, 17);
            this.LblCourseName.TabIndex = 1;
            this.LblCourseName.Text = "Unnamed Course";
            // 
            // LblFilter
            // 
            this.LblFilter.AutoSize = true;
            this.LblFilter.Location = new System.Drawing.Point(298, 18);
            this.LblFilter.Name = "LblFilter";
            this.LblFilter.Size = new System.Drawing.Size(43, 17);
            this.LblFilter.TabIndex = 2;
            this.LblFilter.Text = "Filter:";
            // 
            // LstTeachers
            // 
            this.LstTeachers.FormattingEnabled = true;
            this.LstTeachers.ItemHeight = 16;
            this.LstTeachers.Location = new System.Drawing.Point(301, 68);
            this.LstTeachers.Name = "LstTeachers";
            this.LstTeachers.Size = new System.Drawing.Size(273, 276);
            this.LstTeachers.TabIndex = 3;
            this.LstTeachers.DoubleClick += new System.EventHandler(this.LstTeachers_DoubleClick);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 197);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(272, 62);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnCreateNewTeacher
            // 
            this.BtnCreateNewTeacher.Location = new System.Drawing.Point(12, 276);
            this.BtnCreateNewTeacher.Name = "BtnCreateNewTeacher";
            this.BtnCreateNewTeacher.Size = new System.Drawing.Size(272, 68);
            this.BtnCreateNewTeacher.TabIndex = 5;
            this.BtnCreateNewTeacher.Text = "Create new teacher";
            this.BtnCreateNewTeacher.UseVisualStyleBackColor = true;
            this.BtnCreateNewTeacher.Click += new System.EventHandler(this.BtnCreateNewTeacher_Click);
            // 
            // TxtFilter
            // 
            this.TxtFilter.Location = new System.Drawing.Point(347, 18);
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(227, 22);
            this.TxtFilter.TabIndex = 6;
            this.TxtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            // 
            // SelectTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 363);
            this.Controls.Add(this.TxtFilter);
            this.Controls.Add(this.BtnCreateNewTeacher);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LstTeachers);
            this.Controls.Add(this.LblFilter);
            this.Controls.Add(this.LblCourseName);
            this.Controls.Add(this.LblAddingTo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectTeacher";
            this.Text = "SelectTeacher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectTeacher_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectTeacher_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAddingTo;
        private System.Windows.Forms.Label LblCourseName;
        private System.Windows.Forms.Label LblFilter;
        private System.Windows.Forms.ListBox LstTeachers;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnCreateNewTeacher;
        private System.Windows.Forms.TextBox TxtFilter;
    }
}