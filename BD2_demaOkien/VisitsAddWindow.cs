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
        private int visitId;
        private ViewMode openMode;
        public VisitsAddWindow(ViewMode openMode, int patientId, int? visitId=null)
        {
            this.visitId = visitId.HasValue ? visitId.Value : -1;
            this.openMode = openMode;
            InitializeComponent();
            using (var Db = new BD2_demaOkien.Data.BD2_2Db())
            {
                var doctors = from doctor in Db.Worker
                              where doctor.Role.ToUpper() == "DOCTOR"
                              select new
                              {
                                  id = doctor.Worker_id,
                                  name = doctor.First_name.ToString() + " " + doctor.Last_name.ToString()
                              };
                comboBoxDoctor.DataSource = doctors.ToList();
                comboBoxDoctor.DisplayMember = "name";
                comboBoxDoctor.ValueMember = "id";
            }
            if (openMode == ViewMode.CREATE)
            {
                PatientData p = BizzLayer.Visits.getPatientById((int)patientId);
                this.dateTimeVisitDate.Value = DateTime.Now;
                textBoxPatientPESEL.Text = p.PESEL;
                textBoxPatientName.Text = p.First_name + " " + p.Last_name;
                comboBoxDoctor.SelectedIndex = -1;
            }
            else
            {
                Data.Visit visit = BizzLayer.Visits.GetByID(this.visitId);
                if(visit==null)
                {
                    MessageBox.Show("Nie znaleziono wizyty!");
                    Close();
                    return;
                }
                dateTimeVisitDate.Value = visit.ending_date.Value;
                dateTimeVisitTime.Value = visit.ending_date.Value;
                textBoxPatientPESEL.Text = visit.Patient.PESEL;
                textBoxPatientName.Text = visit.Patient.First_name + " " + visit.Patient.Last_name;
                comboBoxDoctor.SelectedValue = visit.Doctor.Worker_id;
            }
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
            Data.Patient patient = BizzLayer.Patients.getByPESEL(textBoxPatientPESEL.Text);
            if (patient == null)
            {
                MessageBox.Show("Nieprawidłowy pacjent");
                return;
            }
            Data.Worker doctor = Worker.getByID((int)comboBoxDoctor.SelectedValue);
            if (doctor == null)
            {
                MessageBox.Show("Nieprawidłowy lekarz");
                return;
            }
            DateTime visitTime = dateTimeVisitDate.Value.Date + dateTimeVisitTime.Value.TimeOfDay;

            if (this.openMode == ViewMode.CREATE)
            {
                Data.Visit visit = new Data.Visit
                {
                    Patient = patient,
                    Doctor = doctor,
                    registration_date = DateTime.Now,
                    ending_date = visitTime
                };
                BizzLayer.Visits.Add(visit);
                Close();
            }
            else
            {
                Data.Visit visit = BizzLayer.Visits.GetByID(visitId);
                visit.Patient = patient;
                visit.Doctor = doctor;
                visit.ending_date = visitTime;
                BizzLayer.Visits.Modify(visit);
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

        private void textBoxPatientPESEL_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
