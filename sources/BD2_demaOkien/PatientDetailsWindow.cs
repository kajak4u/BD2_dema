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
        private int? patientId;
        public PatientDetailsWindow(ViewMode mode, int id)
        {
            InitializeComponent();
            this.patientId = id;
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
        }

        private void PatientDataWindow_Load(object sender, EventArgs e)
        {
            if (patientId.HasValue)
            {
                PatientData patient = BizzLayer.Visits.getPatientById(patientId.Value);
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
                    string cityName = textBoxCity.Text;
                    if (cityName == "")
                    {
                        MainWindow.ShowError("Brak miasta zamieszkania.");
                        return;
                    }
                    try
                    {
                        BizzLayer.Visits.setPatientData(textBoxName.Text, textBoxSurname.Text, textBoxPESEL.Text, textBoxPhone.Text, textBoxCity.Text, textBoxStreet.Text, houseNo, flatNo, null);
                    }
                    catch (EntityValidationErrorWrapper ex)
                    {
                        ex.FormatForField("City", "Miasto");
                        ex.FormatForField("Street", "Ulica");
                        ex.FormatForField("First_name", "Imię");
                        ex.FormatForField("Last_name", "Nazwisko");
                        ex.FormatForField("Phone_number", "Nr telefonu");
                        ex.FormatForField("PESEL", "PESEL"); 
                        MainWindow.ShowError(ex.FullMessage);
                        DialogResult = DialogResult.None;
                        return;
                    }
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
                string cityName = textBoxCity.Text;
                if (cityName == "")
                {
                    MainWindow.ShowError("Brak miasta zamieszkania.");
                    return;
                }
                try
                {
                    BizzLayer.Visits.editPatientData(textBoxName.Text, textBoxSurname.Text, textBoxPESEL.Text, textBoxPhone.Text, textBoxCity.Text, textBoxStreet.Text, houseNo, flatNo, patientId.Value);
                }
                catch (EntityValidationErrorWrapper ex)
                {
                    ex.FormatForField("City", "Miasto");
                    ex.FormatForField("Street", "Ulica");
                    ex.FormatForField("First_name", "Imię");
                    ex.FormatForField("Last_name", "Nazwisko");
                    ex.FormatForField("Phone_number", "Nr telefonu");
                    ex.FormatForField("PESEL", "PESEL");
                    MainWindow.ShowError(ex.FullMessage);
                    DialogResult = DialogResult.None;
                    return;
                }
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
