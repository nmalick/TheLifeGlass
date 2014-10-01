namespace TheLifeGlass
{
    partial class frmPlanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanner));
            this.lstTopPriority = new System.Windows.Forms.ListBox();
            this.lstMediumPriority = new System.Windows.Forms.ListBox();
            this.lstLowPriority = new System.Windows.Forms.ListBox();
            this.lstExtras = new System.Windows.Forms.ListBox();
            this.btnAddTasks = new System.Windows.Forms.Button();
            this.btnEditTasks = new System.Windows.Forms.Button();
            this.btnRemoveTasks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTopPriority
            // 
            this.lstTopPriority.AllowDrop = true;
            this.lstTopPriority.BackColor = System.Drawing.Color.DarkRed;
            this.lstTopPriority.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lstTopPriority.FormattingEnabled = true;
            this.lstTopPriority.Location = new System.Drawing.Point(31, 18);
            this.lstTopPriority.Name = "lstTopPriority";
            this.lstTopPriority.Size = new System.Drawing.Size(348, 173);
            this.lstTopPriority.TabIndex = 0;
            // 
            // lstMediumPriority
            // 
            this.lstMediumPriority.AllowDrop = true;
            this.lstMediumPriority.BackColor = System.Drawing.Color.OrangeRed;
            this.lstMediumPriority.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lstMediumPriority.FormattingEnabled = true;
            this.lstMediumPriority.Location = new System.Drawing.Point(31, 209);
            this.lstMediumPriority.Name = "lstMediumPriority";
            this.lstMediumPriority.Size = new System.Drawing.Size(348, 173);
            this.lstMediumPriority.TabIndex = 1;
            // 
            // lstLowPriority
            // 
            this.lstLowPriority.AllowDrop = true;
            this.lstLowPriority.BackColor = System.Drawing.Color.Olive;
            this.lstLowPriority.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lstLowPriority.FormattingEnabled = true;
            this.lstLowPriority.Location = new System.Drawing.Point(31, 400);
            this.lstLowPriority.Name = "lstLowPriority";
            this.lstLowPriority.Size = new System.Drawing.Size(348, 173);
            this.lstLowPriority.TabIndex = 2;
            // 
            // lstExtras
            // 
            this.lstExtras.AllowDrop = true;
            this.lstExtras.BackColor = System.Drawing.Color.LightGreen;
            this.lstExtras.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lstExtras.FormattingEnabled = true;
            this.lstExtras.Location = new System.Drawing.Point(31, 599);
            this.lstExtras.Name = "lstExtras";
            this.lstExtras.Size = new System.Drawing.Size(348, 173);
            this.lstExtras.TabIndex = 3;
            // 
            // btnAddTasks
            // 
            this.btnAddTasks.Location = new System.Drawing.Point(460, 138);
            this.btnAddTasks.Name = "btnAddTasks";
            this.btnAddTasks.Size = new System.Drawing.Size(302, 97);
            this.btnAddTasks.TabIndex = 4;
            this.btnAddTasks.Text = "Add Tasks";
            this.btnAddTasks.UseVisualStyleBackColor = true;
            this.btnAddTasks.Click += new System.EventHandler(this.btnAddTasks_Click);
            // 
            // btnEditTasks
            // 
            this.btnEditTasks.Location = new System.Drawing.Point(460, 341);
            this.btnEditTasks.Name = "btnEditTasks";
            this.btnEditTasks.Size = new System.Drawing.Size(302, 97);
            this.btnEditTasks.TabIndex = 5;
            this.btnEditTasks.Text = "Edit Tasks";
            this.btnEditTasks.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTasks
            // 
            this.btnRemoveTasks.Location = new System.Drawing.Point(460, 547);
            this.btnRemoveTasks.Name = "btnRemoveTasks";
            this.btnRemoveTasks.Size = new System.Drawing.Size(302, 97);
            this.btnRemoveTasks.TabIndex = 6;
            this.btnRemoveTasks.Text = "Remove Tasks";
            this.btnRemoveTasks.UseVisualStyleBackColor = true;
            // 
            // frmPlanner
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(811, 521);
            this.Controls.Add(this.btnRemoveTasks);
            this.Controls.Add(this.btnEditTasks);
            this.Controls.Add(this.btnAddTasks);
            this.Controls.Add(this.lstExtras);
            this.Controls.Add(this.lstLowPriority);
            this.Controls.Add(this.lstMediumPriority);
            this.Controls.Add(this.lstTopPriority);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPlanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TLG--Planner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTopPriority;
        private System.Windows.Forms.ListBox lstMediumPriority;
        private System.Windows.Forms.ListBox lstLowPriority;
        private System.Windows.Forms.ListBox lstExtras;
        private System.Windows.Forms.Button btnAddTasks;
        private System.Windows.Forms.Button btnEditTasks;
        private System.Windows.Forms.Button btnRemoveTasks;
    }
}