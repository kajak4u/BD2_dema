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
    public partial class Patients : Form
    {
        public Patients()
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
            // TODO: This line of code loads data into the 'bD2_demaDataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.bD2_demaDataSet.Patients);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.patientsTableAdapter.FillBy(this.bD2_demaDataSet.Patients);
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
            new VisitsWindow().ShowDialog();
        }
    }
}
