namespace TimeRegistartion
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.LstCourses = new System.Windows.Forms.ListBox();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.LblCourses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstCourses
            // 
            this.LstCourses.FormattingEnabled = true;
            this.LstCourses.ItemHeight = 16;
            this.LstCourses.Location = new System.Drawing.Point(43, 57);
            this.LstCourses.Name = "LstCourses";
            this.LstCourses.Size = new System.Drawing.Size(271, 292);
            this.LstCourses.TabIndex = 0;
            this.LstCourses.DoubleClick += new System.EventHandler(this.LstCourses_DoubleClick);
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(43, 378);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(270, 58);
            this.BtnOpen.TabIndex = 1;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // LblCourses
            // 
            this.LblCourses.AutoSize = true;
            this.LblCourses.Location = new System.Drawing.Point(118, 18);
            this.LblCourses.Name = "LblCourses";
            this.LblCourses.Size = new System.Drawing.Size(123, 17);
            this.LblCourses.TabIndex = 2;
            this.LblCourses.Text = "Available courses:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.LblCourses);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.LstCourses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(397, 497);
            this.MinimumSize = new System.Drawing.Size(397, 497);
            this.Name = "Menu";
            this.Text = "Time Registration App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstCourses;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Label LblCourses;
    }
}

