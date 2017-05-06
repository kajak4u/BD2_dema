using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD2_demaOkien
{
    public partial class VisitsWindow_Doctor : Form
    {
        public VisitsWindow_Doctor()
        {
            InitializeComponent();
            this.dateTimeMyVisitsDate.Value = DateTime.Now;
        }

        private void VisitsWindow_Doctor_Load(object sender, EventArgs e)
        {

        }

        private void dateTimeMyVisitsDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime newDay = dateTimeMyVisitsDate.Value;
            daySchedulerMyVisits.SetViewRange(newDay, newDay);
        }
    }
}
