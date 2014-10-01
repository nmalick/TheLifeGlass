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
    public partial class frmCalendar : Form
    {
        public frmCalendar()
        {
            InitializeComponent();
        }

        private void frmCalendar_Load(object sender, EventArgs e)
        {
            //this.monthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }
    }
}
