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
            setSchedulerDate(DateTime.Now);
        }

        private void setSchedulerDate(DateTime newDay)
        {
            daySchedulerMyVisits.SetViewRange(newDay, newDay);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setSchedulerDate(dateTimeMyVisitsDate.Value);
        }

        private void buttonPerform_Click(object sender, EventArgs e)
        {
            new VisitsPerformWindow(0/*FIX IT!!!*/).ShowDialog();
#warning VisitWindow_Doctor - brak ID wizyty
        }
    }
}
