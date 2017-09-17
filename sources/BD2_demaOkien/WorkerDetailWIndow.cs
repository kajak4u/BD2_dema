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
    public partial class WorkerDetailsWindow : Form
    {
        private ViewMode viewMode;
        private int? workerId;
        public WorkerDetailsWindow(ViewMode mode, int id)
        {
            InitializeComponent();
            this.workerId = id;
            this.viewMode = mode;
            SetEnabledControls();
        }

        private void SetEnabledControls()
        {
            bool readOnly = (viewMode == ViewMode.VIEW || viewMode == ViewMode.VIEW_ONLY);
            panelAddEdit.Visible = readOnly;
            panelView.Visible = !readOnly;
            buttonEdit.Visible = (viewMode != ViewMode.VIEW_ONLY);

            textBoxName.ReadOnly = readOnly;
            textBoxSurname.ReadOnly = readOnly;
            textBoxPESEL.ReadOnly = readOnly;
            textBoxPhone.ReadOnly = readOnly;

            textBoxCity.ReadOnly = readOnly;
            textBoxStreet.ReadOnly = readOnly;
            textBoxHouseNo.ReadOnly = readOnly;
            textBoxFlatNo.ReadOnly = readOnly;
			dateTimePicker1.Enabled = !readOnly;
			comboBox2.Enabled = !readOnly;
			textBox3.ReadOnly = readOnly;
			textBox4.ReadOnly = readOnly;
			textBox1.Visible = !readOnly;
			label13.Visible = !readOnly;
        }

        private void WorkerDataWindow_Load(object sender, EventArgs e)
        {
            if (workerId.HasValue)
            {
#warning DODAĆ KLASĘ WorkerData do BizzLayer i PODŁĄCZYĆ TUTAJ JAKO ŹRÓDŁO DANYCH
				// WorkerData worker = BizzLayer.Visits.getWorkerById(workerId.Value);
				PatientData worker = BizzLayer.Visits.getPatientById(workerId.Value);
				textBoxName.Text = worker?.First_name;
                textBoxSurname.Text = worker?.Last_name;
                textBoxPESEL.Text = worker?.PESEL;
                textBoxPhone.Text = worker?.Phone_number;
                textBoxCity.Text = worker?.City;
                textBoxStreet.Text = worker?.Street;
                textBoxHouseNo.Text = worker?.HouseNo.ToString();
                textBoxFlatNo.Text = worker?.FlatNo.ToString();

            }

        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (viewMode == ViewMode.CREATE)
            {
                int? flatNo = null;
                try
                {
                    int houseNo;
                    if(!int.TryParse(textBoxHouseNo.Text, out houseNo))
                    {
                        MainWindow.ShowError("Nieprawidłowy nr domu");
                        return;
                    }

                    if(textBoxFlatNo.Text!=null && textBoxFlatNo.Text!="")
                    {
                        int NonNullFlatNo;
                        if(!int.TryParse(textBoxFlatNo.Text, out NonNullFlatNo))
                        {
                            MainWindow.ShowError("Nieprawidłowy nr mieszkania");
                            return;
                        }
                        flatNo = NonNullFlatNo;
                    }

                    BizzLayer.Visits.setPatientData(textBoxName.Text, textBoxSurname.Text, textBoxPESEL.Text, textBoxPhone.Text, textBoxCity.Text, textBoxStreet.Text, houseNo, flatNo, null);
                    Close();
                }
                catch (Exception exx)
                {
                    MainWindow.ShowError(exx.Message
                        + Environment.NewLine + Environment.NewLine + exx.StackTrace);
                       // + Environment.NewLine + Environment.NewLine + exx.InnerException.ToString());
                }

            }
            else if (viewMode == ViewMode.EDIT)
            {
                int? flatNo = null;
                int houseNo;
                if (!int.TryParse(textBoxHouseNo.Text, out houseNo))
                {
                    MainWindow.ShowError("Nieprawidłowy nr domu");
                    return;
                }

                if (textBoxFlatNo.Text != null && textBoxFlatNo.Text != "")
                {
                    int NonNullFlatNo;
                    if (!int.TryParse(textBoxFlatNo.Text, out NonNullFlatNo))
                    {
                        MainWindow.ShowError("Nieprawidłowy nr mieszkania");
                        return;
                    }
                    flatNo = NonNullFlatNo;
                }
                BizzLayer.Visits.editPatientData(textBoxName.Text, textBoxSurname.Text, textBoxPESEL.Text, textBoxPhone.Text, textBoxCity.Text, textBoxStreet.Text, houseNo, flatNo, workerId.Value);
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
