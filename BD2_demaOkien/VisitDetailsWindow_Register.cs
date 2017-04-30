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
    [Description("Okno wizyty widziane przez rejestratorkę")]
    public partial class VisitDetailsWindow_Register : Form
    {
        private ViewMode openMode;
        public VisitDetailsWindow_Register(ViewMode openMode)
        {
            InitializeComponent();
            this.dateTimeVisitDate.Value = DateTime.Now;
            this.openMode = openMode;
            SetEnabledControls();
        }

        private void dateTimeVisitDate_ValueChanged(object sender, EventArgs e)
        {
            this.dayScheduler.SetViewRange(this.dateTimeVisitDate.Value, dateTimeVisitDate.Value);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            this.openMode = ViewMode.MODE_EDIT;
            SetEnabledControls();
        }

        private void SetEnabledControls()
        {
            bool readOnly = (openMode == ViewMode.MODE_VIEW);
            ResultPanel.Visible = !readOnly;
            ViewPanel.Visible = readOnly;
            dayScheduler.Enabled = !readOnly;
            DataPanel.Enabled = !readOnly;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.openMode = ViewMode.MODE_VIEW;
            SetEnabledControls();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            this.openMode = ViewMode.MODE_VIEW;
            SetEnabledControls();
        }
    }
}
