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
    public partial class PatientDetailsWindow : Form
    {
        private ViewMode viewMode;
        private int patientId;
        public PatientDetailsWindow(ViewMode mode, int id)
        {
            InitializeComponent();
            this.patientId = id;
            this.viewMode = mode;
            SetEnabledControls();
        }

        private void SetEnabledControls()
        {
            bool readOnly = (viewMode == ViewMode.VIEW);
            panelAddEdit.Visible = readOnly;
            panelView.Visible = !readOnly;

            textBoxName.ReadOnly = readOnly;
            textBoxSurname.ReadOnly = readOnly;
            textBoxPESEL.ReadOnly = readOnly;
            textBoxPhone.ReadOnly = readOnly;

            textBoxCity.ReadOnly = readOnly;
            textBoxStreet.ReadOnly = readOnly;
            textBoxHouseNo.ReadOnly = readOnly;
            textBoxFlatNo.ReadOnly = readOnly;
        }

        private void PatientDataWindow_Load(object sender, EventArgs e)
        {
            if (this.viewMode == ViewMode.VIEW || this.viewMode == ViewMode.EDIT)
            {
                PatientData patient = Visit.getPatientById(patientId);
                textBoxName.Text = patient?.First_name;
                textBoxSurname.Text = patient?.Last_name;
                textBoxPESEL.Text = patient?.PESEL;
                textBoxPhone.Text = patient?.Phone_number;
                textBoxCity.Text = patient?.City;
                textBoxStreet.Text = patient?.Street;
                textBoxHouseNo.Text = patient?.HouseNo.ToString();
                textBoxFlatNo.Text = patient?.FlatNo.ToString();

            }
           
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (viewMode == ViewMode.CREATE)
            {
                Visit.setPatientData(textBoxName.Text, textBoxSurname.Text, textBoxPESEL.Text, textBoxPhone.Text, textBoxCity.Text, textBoxStreet.Text, textBoxHouseNo.Text, textBoxFlatNo.Text, null);
                Close();
            }
            else if (viewMode == ViewMode.EDIT)
            {
                Visit.setPatientData(textBoxName.Text, textBoxSurname.Text, textBoxPESEL.Text, textBoxPhone.Text, textBoxCity.Text, textBoxStreet.Text, textBoxHouseNo.Text, textBoxFlatNo.Text, patientId);
                Close();
            }
            else
            {
                viewMode = ViewMode.VIEW;
                SetEnabledControls();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (viewMode == ViewMode.CREATE)
                Close();
            else
            {
                viewMode = ViewMode.VIEW;
                SetEnabledControls();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            viewMode = ViewMode.EDIT;
            SetEnabledControls();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
