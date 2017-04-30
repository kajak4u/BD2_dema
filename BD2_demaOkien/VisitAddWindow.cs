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
    public partial class VisitAddWindow : Form
    {
        public VisitAddWindow()
        {
            InitializeComponent();
            this.dateTimeVisitDate.Value = DateTime.Now;
        }

        private void dateTimeVisitDate_ValueChanged(object sender, EventArgs e)
        {
            this.dayScheduler.SetViewRange(this.dateTimeVisitDate.Value, dateTimeVisitDate.Value);
        }
    }
}
