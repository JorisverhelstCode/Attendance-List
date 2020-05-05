namespace Attendance_List
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
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LstBoxCourses = new System.Windows.Forms.ListBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.TxtName.Size = new System.Drawing.Size(251, 22);
            this.TxtName.TabIndex = 1;
            // 
            // LstBoxCourses
            // 
            this.LstBoxCourses.FormattingEnabled = true;
            this.LstBoxCourses.ItemHeight = 16;
            this.LstBoxCourses.Location = new System.Drawing.Point(18, 88);
            this.LstBoxCourses.Name = "LstBoxCourses";
            this.LstBoxCourses.Size = new System.Drawing.Size(327, 276);
            this.LstBoxCourses.TabIndex = 2;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(17, 387);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(131, 56);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ParticipantDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LstBoxCourses);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblName);
            this.Name = "ParticipantDetails";
            this.Text = "ParticipantDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.ListBox LstBoxCourses;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button button1;
    }
}