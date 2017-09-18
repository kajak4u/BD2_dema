using BD2_demaOkien.BizzLayer;
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
        public WorkerDetailsWindow(ViewMode mode, int? id)
        {
            InitializeComponent();
            this.workerId = id;
            this.viewMode = mode;
            SetEnabledControls();
            comboBoxRole.DataSource = UserRole.roleDictionary
                .Where(role => !role.Key.Equals(""))
                .ToList();
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
			dateTimeExpire.Enabled = !readOnly;
			comboBoxRole.Enabled = !readOnly;
			textBoxLogin.ReadOnly = readOnly;
			textBoxPassword.ReadOnly = readOnly;
			textBoxPassword2.Visible = !readOnly;
			label13.Visible = !readOnly;
            textBoxNPWZ.ReadOnly = readOnly;
            textBoxEmail.ReadOnly = readOnly;
        }

        private void WorkerDataWindow_Load(object sender, EventArgs e)
        {
            if (workerId.HasValue)
            {
				WorkerData worker = BizzLayer.Workers.getByID(workerId.Value);
				textBoxName.Text = worker?.First_name;
                textBoxSurname.Text = worker?.Last_name;
                textBoxPESEL.Text = worker?.PESEL;
                textBoxPhone.Text = worker?.Phone_number;
                dateTimeExpire.Checked = worker.ExpirationDate.HasValue;
                textBoxNPWZ.Text = worker?.NPWZ.ToString();
                if(dateTimeExpire.Checked)
                    dateTimeExpire.Value = worker.ExpirationDate.Value;
                textBoxCity.Text = worker?.City;
                textBoxStreet.Text = worker?.Street;
                textBoxHouseNo.Text = worker?.HouseNo.ToString();
                textBoxFlatNo.Text = worker?.FlatNo.ToString();
                textBoxEmail.Text = worker?.email;
                comboBoxRole.SelectedValue = worker?.role;
                textBoxLogin.Text = worker?.login;
            }

        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            int? npwz = null;
            if(textBoxNPWZ.Visible)
            {
                int NotNullNpwz;
                if (!int.TryParse(textBoxNPWZ.Text, out NotNullNpwz))
                {
                    MainWindow.ShowError("Nieprawidłowy NPWZ");
                    return;
                }
                npwz = NotNullNpwz;
            }
            WorkerData workerData = new WorkerData
            {
                First_name = textBoxName.Text,
                Last_name = textBoxSurname.Text,
                PESEL = textBoxPESEL.Text,
                Phone_number = textBoxPhone.Text,
                City = textBoxCity.Text,
                Street = textBoxStreet.Text,
                email = textBoxEmail.Text,
                role = (string)comboBoxRole.SelectedValue,
                ExpirationDate = dateTimeExpire.Checked ? dateTimeExpire.Value : (DateTime?)null,
                login = textBoxLogin.Text,
                NPWZ = npwz
            };
            if (viewMode == ViewMode.CREATE)
            {
                int? flatNo = null;
                try
                {
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
                    workerData.HouseNo = houseNo;
                    workerData.FlatNo = flatNo;
                    string pass1 = textBoxPassword.Text;
                    string pass2 = textBoxPassword2.Text;
                    if (pass1 == "" && pass2 == "")
                    {
                        MainWindow.ShowError("Podaj hasło dla użytkownika");
                        return;
                    }
                    if (!pass1.Equals(pass2))
                    {
                        MainWindow.ShowError("Podane hasła są różne");
                        return;
                    }
                    workerData.Password = pass1;
                    BizzLayer.Workers.Create(workerData);
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
                string pass1 = textBoxPassword.Text;
                string pass2 = textBoxPassword2.Text;
                if (pass1!="" || pass2!="")
                {
                    if(!pass1.Equals(pass2))
                    {
                        MainWindow.ShowError("Podane hasła są różne");
                        return;
                    }
                    workerData.Password = pass1;
                }
                workerData.Worker_id = workerId.Value;
                workerData.HouseNo = houseNo;
                workerData.FlatNo = flatNo;
                BizzLayer.Workers.Update(workerData);
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

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool visible = false;
            if (comboBoxRole.SelectedValue != null && (string)comboBoxRole.SelectedValue == "doctor")
                visible = true;
            label15.Visible = textBoxNPWZ.Visible = visible;
        }
    }
}
