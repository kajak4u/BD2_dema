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
    public partial class VisitsAddWindow : Form
    {
        private ViewMode openMode;
        public VisitsAddWindow(ViewMode openMode)
        {
            InitializeComponent();
            this.dateTimeVisitDate.Value = DateTime.Now;
            this.openMode = openMode;
            textBoxPatientPESEL.Text = "01234567890";
            textBoxPatientName.Text = "/**przekazane z okna nadrzędnego**/";
            SetEnabledControls();
        }

        private void buttonSetScheduler(object sender, EventArgs e)
        {
            this.dayScheduler.SetViewRange(this.dateTimeVisitDate.Value, dateTimeVisitDate.Value);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            this.openMode = ViewMode.EDIT;
            SetEnabledControls();
        }

        private void SetEnabledControls()
        {
            bool readOnly = (openMode == ViewMode.VIEW);
            ResultPanel.Visible = !readOnly;
            ViewPanel.Visible = readOnly;
            dayScheduler.Enabled = !readOnly;
            DataPanel.Enabled = !readOnly;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (this.openMode == ViewMode.CREATE)
                Close();
            else
            {
                this.openMode = ViewMode.VIEW;
                SetEnabledControls();
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (this.openMode == ViewMode.CREATE)
                Close();
            else
            {
                this.openMode = ViewMode.VIEW;
                SetEnabledControls();
            }
        }

        private void VisitDetailsWindow_Register_Load(object sender, EventArgs e)
        {
            buttonSetScheduler(this, null); // żeby scheduler nie dostał śmieci
        }

        private void ResultPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dayScheduler_ItemFocusChanged(object sender, CalendarTimeEventArgs e)
        {
            dateTimeVisitDate.Value = e.startTime;
        }

        private void buttonChooseDoctor_Click(object sender, EventArgs e)
        {
            ChooseDoctorModal modal = new ChooseDoctorModal();
            if (modal.ShowDialog() == DialogResult.OK)
                comboBoxDoctor.Text = modal.ChosenDoctor;
        }
    }
}
