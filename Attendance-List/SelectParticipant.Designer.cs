namespace Attendance_List
{
    partial class SelectParticipant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectParticipant));
            this.LstParticipants = new System.Windows.Forms.ListBox();
            this.LblFilter = new System.Windows.Forms.Label();
            this.TxtFilter = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnCreateNewParticipant = new System.Windows.Forms.Button();
            this.LblAddingTo = new System.Windows.Forms.Label();
            this.LblCourseName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstParticipants
            // 
            this.LstParticipants.FormattingEnabled = true;
            this.LstParticipants.ItemHeight = 16;
            this.LstParticipants.Location = new System.Drawing.Point(295, 67);
            this.LstParticipants.Name = "LstParticipants";
            this.LstParticipants.Size = new System.Drawing.Size(273, 276);
            this.LstParticipants.TabIndex = 0;
            this.LstParticipants.DoubleClick += new System.EventHandler(this.LstParticipants_DoubleClick);
            // 
            // LblFilter
            // 
            this.LblFilter.AutoSize = true;
            this.LblFilter.Location = new System.Drawing.Point(292, 17);
            this.LblFilter.Name = "LblFilter";
            this.LblFilter.Size = new System.Drawing.Size(43, 17);
            this.LblFilter.TabIndex = 1;
            this.LblFilter.Text = "Filter:";
            // 
            // TxtFilter
            // 
            this.TxtFilter.Location = new System.Drawing.Point(345, 17);
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(223, 22);
            this.TxtFilter.TabIndex = 2;
            this.TxtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 195);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(272, 62);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnCreateNewParticipant
            // 
            this.BtnCreateNewParticipant.Location = new System.Drawing.Point(12, 279);
            this.BtnCreateNewParticipant.Name = "BtnCreateNewParticipant";
            this.BtnCreateNewParticipant.Size = new System.Drawing.Size(272, 64);
            this.BtnCreateNewParticipant.TabIndex = 4;
            this.BtnCreateNewParticipant.Text = "Create new participant";
            this.BtnCreateNewParticipant.UseVisualStyleBackColor = true;
            this.BtnCreateNewParticipant.Click += new System.EventHandler(this.BtnCreateNewParticipant_Click);
            // 
            // LblAddingTo
            // 
            this.LblAddingTo.AutoSize = true;
            this.LblAddingTo.Location = new System.Drawing.Point(89, 21);
            this.LblAddingTo.Name = "LblAddingTo";
            this.LblAddingTo.Size = new System.Drawing.Size(72, 17);
            this.LblAddingTo.TabIndex = 5;
            this.LblAddingTo.Text = "Adding to:";
            // 
            // LblCourseName
            // 
            this.LblCourseName.AutoSize = true;
            this.LblCourseName.Location = new System.Drawing.Point(23, 66);
            this.LblCourseName.Name = "LblCourseName";
            this.LblCourseName.Size = new System.Drawing.Size(121, 17);
            this.LblCourseName.TabIndex = 6;
            this.LblCourseName.Text = "The Course name";
            // 
            // SelectParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 363);
            this.Controls.Add(this.LblCourseName);
            this.Controls.Add(this.LblAddingTo);
            this.Controls.Add(this.BtnCreateNewParticipant);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtFilter);
            this.Controls.Add(this.LblFilter);
            this.Controls.Add(this.LstParticipants);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectParticipant";
            this.Text = "SelectParticipant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectParticipant_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectParticipant_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstParticipants;
        private System.Windows.Forms.Label LblFilter;
        private System.Windows.Forms.TextBox TxtFilter;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnCreateNewParticipant;
        private System.Windows.Forms.Label LblAddingTo;
        private System.Windows.Forms.Label LblCourseName;
    }
}