namespace TheLifeGlass
{
    partial class frmAddTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTask));
            this.lstTaskName = new System.Windows.Forms.ListBox();
            this.lstTime = new System.Windows.Forms.ListBox();
            this.lstPriority = new System.Windows.Forms.ListBox();
            this.btnSaveTask = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateNewTask = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lstTaskName
            // 
            this.lstTaskName.FormattingEnabled = true;
            this.lstTaskName.Location = new System.Drawing.Point(63, 32);
            this.lstTaskName.Name = "lstTaskName";
            this.lstTaskName.Size = new System.Drawing.Size(264, 43);
            this.lstTaskName.TabIndex = 0;
            // 
            // lstTime
            // 
            this.lstTime.FormattingEnabled = true;
            this.lstTime.Location = new System.Drawing.Point(63, 189);
            this.lstTime.Name = "lstTime";
            this.lstTime.Size = new System.Drawing.Size(264, 43);
            this.lstTime.TabIndex = 2;
            // 
            // lstPriority
            // 
            this.lstPriority.FormattingEnabled = true;
            this.lstPriority.Location = new System.Drawing.Point(63, 274);
            this.lstPriority.Name = "lstPriority";
            this.lstPriority.Size = new System.Drawing.Size(264, 43);
            this.lstPriority.TabIndex = 3;
            // 
            // btnSaveTask
            // 
            this.btnSaveTask.Location = new System.Drawing.Point(482, 180);
            this.btnSaveTask.Name = "btnSaveTask";
            this.btnSaveTask.Size = new System.Drawing.Size(198, 52);
            this.btnSaveTask.TabIndex = 4;
            this.btnSaveTask.Text = "Save task";
            this.btnSaveTask.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(482, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(198, 52);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateNewTask
            // 
            this.dateNewTask.Location = new System.Drawing.Point(63, 117);
            this.dateNewTask.Name = "dateNewTask";
            this.dateNewTask.Size = new System.Drawing.Size(264, 20);
            this.dateNewTask.TabIndex = 6;
            // 
            // frmAddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(707, 393);
            this.Controls.Add(this.dateNewTask);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveTask);
            this.Controls.Add(this.lstPriority);
            this.Controls.Add(this.lstTime);
            this.Controls.Add(this.lstTaskName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddTask";
            this.Text = "TLG--Add Task";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTaskName;
        private System.Windows.Forms.ListBox lstTime;
        private System.Windows.Forms.ListBox lstPriority;
        private System.Windows.Forms.Button btnSaveTask;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateNewTask;
    }
}