﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheLifeGlass
{
    public partial class frmIntroLifeGlass : Form
    {
        public frmIntroLifeGlass()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //opens up the Actual App 
            Form frmApp = new frmLifeGlassApp();
            frmApp.Show();
            // this.Close(); Closing the whole program as well for some reason
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
