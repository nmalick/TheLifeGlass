namespace TheLifeGlass
{
    partial class frmLifeGlassApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLifeGlassApp));
            this.btnPlanner = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.lstList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPlanner
            // 
            this.btnPlanner.Location = new System.Drawing.Point(12, 363);
            this.btnPlanner.Name = "btnPlanner";
            this.btnPlanner.Size = new System.Drawing.Size(356, 125);
            this.btnPlanner.TabIndex = 0;
            this.btnPlanner.Text = "Open Planner";
            this.btnPlanner.UseVisualStyleBackColor = true;
            this.btnPlanner.Click += new System.EventHandler(this.btnPlanner_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.Location = new System.Drawing.Point(461, 363);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(356, 125);
            this.btnCalendar.TabIndex = 1;
            this.btnCalendar.Text = "Open Caledar";
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // lstList
            // 
            this.lstList.FormattingEnabled = true;
            this.lstList.Location = new System.Drawing.Point(12, 12);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(584, 329);
            this.lstList.TabIndex = 2;
            // 
            // frmLifeGlassApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::TheLifeGlass.Properties.Resources.images__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 500);
            this.Controls.Add(this.lstList);
            this.Controls.Add(this.btnCalendar);
            this.Controls.Add(this.btnPlanner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLifeGlassApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Life Glass";
            this.Load += new System.EventHandler(this.frmLifeGlassApp_Load);
            this.ResumeLayout(false);

        }

        private void frmLifeGlassApp_Load(object sender, System.EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Button btnPlanner;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.ListBox lstList;
    }
}