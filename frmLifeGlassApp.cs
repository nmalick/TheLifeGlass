using System;
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
    public partial class frmLifeGlassApp : Form
    {
        public frmLifeGlassApp()
        {
            InitializeComponent();
        }

        private void btnPlanner_Click(object sender, EventArgs e)
        {
            //opens up the Planner
            Form frmPlanner = new frmPlanner();
            frmPlanner.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            //opens up the Calendar
            Form frmCalendar = new frmCalendar();
            frmCalendar.Show();
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
