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
        public PatientDetailsWindow(ViewMode mode)
        {
            InitializeComponent();
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

        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            viewMode = ViewMode.VIEW;
            SetEnabledControls();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            viewMode = ViewMode.VIEW;
            SetEnabledControls();
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
