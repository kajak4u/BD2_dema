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
    public partial class PatientsWindow : Form
    {
        public PatientsWindow()
        {
            InitializeComponent();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {
            bool currentExists = (bindingNavigator1.BindingSource!=null && bindingNavigator1.BindingSource.Current != null);

            bindingNavigatorEditItem.Enabled = currentExists;
            bindingNavigatorItemData.Enabled = currentExists;
            bindingNavigatorItemVisits.Enabled = currentExists;
            bindingNavigatorItemTests.Enabled = currentExists;
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_2DataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.bD_2DataSet.Patient);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.patientTableAdapter.Fill(this.bD_2DataSet.Patient);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new PatientDetailsWindow(ViewMode.MODE_CREATE).ShowDialog();
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            new PatientDetailsWindow(ViewMode.MODE_EDIT).ShowDialog();
        }

        private void bindingNavigatorItemVisits_Click(object sender, EventArgs e)
        {
            VisitsWindow visits = new VisitsWindow();
            visits.MdiParent = this.MdiParent;
            visits.Show();
        }

        private void bindingNavigatorItemData_Click(object sender, EventArgs e)
        {
            new PatientDetailsWindow(ViewMode.MODE_VIEW).ShowDialog();
        }
    }
}
