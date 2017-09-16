using BD2_demaOkien.BizzLayer;
using BD2_demaOkien.Data;
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
	public partial class ExaminationsWindow : Form
	{
		private Role userRole;
        public int? patientId;

		public ExaminationsWindow()
		{
			InitializeComponent();
			this.userRole = MainWindow.userRole;
			SetBinderControls();
		}

		private void SetBinderControls()
		{
			if (userRole == Role.REGISTRAR)
			{
				//bindingNavigatorAddNewItem.Visible = false;
			}
		}

		private void bindingNavigatorItemData_Click(object sender, EventArgs e)
		{
            int labExamId = (int)dataGridView1.CurrentRow.Cells["Column7"].Value;

            new ExaminationsDetailWindow(labExamId).ShowDialog();
            LoadData();
		}

		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			//new ExaminationsAddWindow(ExaminationMode.).ShowDialog();
		}
        private void LoadData()
        {
            bindingSource1.DataSource = BizzLayer.LabExaminations.Get(new ExaminationFilterParams
            {
                patient_PESEL = textBoxPESEL.Text,
                data_zlec = dateTimePicker1.Checked ? dateTimePicker1.Value : (DateTime?)null,
                data_wyk  = dateTimePicker1.Checked ? dateTimePicker1.Value : (DateTime?)null,
                status = (string)comboBoxStatus.SelectedValue,
                doctorId = (int?)comboBoxDoctor.SelectedValue,
                labId = (int?)comboBoxLab.SelectedValue,
                klabId = (int?)comboBoxKlab.SelectedValue
            }).ToList();
        }

        private void ExaminationsWindow_Load(object sender, EventArgs e)
        {
            if(patientId.HasValue)
            {
                buttonChoosePatient.Enabled = false;
                textBoxPESEL.Enabled = false;
                Patient patient = BizzLayer.Patients.GetByID(patientId.Value);
                textBoxPESEL.Text = patient.PESEL;
            }
            comboBoxStatus.DataSource = LabExaminationStatus.statusDictionary;
            comboBoxDoctor.DataSource = BizzLayer.Workers.GetAll(Role.DOCTOR)
                .Select(doctor => new
                {
                    id = doctor.Worker_id,
                    name = doctor.First_name + " " + doctor.Last_name
                })
                .ToList();
            comboBoxDoctor.SelectedIndex = -1;
            comboBoxLab.DataSource = BizzLayer.Workers.GetAll(Role.LAB)
                .Select(doctor => new
                {
                    id = doctor.Worker_id,
                    name = doctor.First_name + " " + doctor.Last_name
                })
                .ToList();
            comboBoxLab.SelectedIndex = -1;
            comboBoxKlab.DataSource = BizzLayer.Workers.GetAll(Role.KLAB)
                .Select(doctor => new
                {
                    id = doctor.Worker_id,
                    name = doctor.First_name + " " + doctor.Last_name
                })
                .ToList();
            comboBoxKlab.SelectedIndex = -1;
            switch (userRole)
            {
                case Role.DOCTOR:
                    comboBoxDoctor.SelectedValue = MainWindow.userId;
                    break;
                case Role.LAB:
                    comboBoxLab.SelectedValue = MainWindow.userId;
                    comboBoxStatus.SelectedValue = "COM";
                    break;
                case Role.KLAB:
                    comboBoxKlab.SelectedValue = MainWindow.userId;
                    comboBoxStatus.SelectedValue = "PER";
                    break;
                case Role.REGISTRAR:
                    break;
            }
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBoxStatus.SelectedValue = "";
            comboBoxDoctor.SelectedIndex = -1;
            comboBoxLab.SelectedIndex = -1;
            comboBoxKlab.SelectedIndex = -1;
        }

        private void buttonChoosePatient_Click(object sender, EventArgs e)
        {
            PatientsWindow patients = new PatientsWindow(true);
            patients.MdiParent = this.MdiParent;
            patients.Show();
        }

        private void ExaminationsWindow_Activated(object sender, EventArgs e)
        {
            if(buttonChoosePatient.Focused)
            {
                if(MainWindow.LastSelectResult != null)
                {
                    textBoxPESEL.Text = (string)MainWindow.LastSelectResult;
                }
            }
        }
    }
}
