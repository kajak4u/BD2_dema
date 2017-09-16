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
    public partial class VisitsWindow : Form
    {
        
        private int patientID;
        private Role userRole;
        private int doctorID;

        public VisitsWindow(Role openedRole, int? id)
        {
            userRole = openedRole;
            InitializeComponent();
            if (openedRole == Role.DOCTOR)
                doctorID = (int)id.Value;
            else
                patientID = (int)id.Value;
        }

        private void VisitsWindow_Load(object sender, EventArgs e)
        {
            bool ch1 = dateTimePicker1.Checked,
                ch2 = dateTimePicker2.Checked;
            dateTimePicker1.Value = dateTimePicker2.Value = DateTime.Now;
            dateTimePicker1.Checked = ch1;
            dateTimePicker2.Checked = ch2;

            comboBox1.DataSource = VisitStatus.statusDictionary;

            comboBox2.DataSource = BizzLayer.Workers
                .GetAll(Role.DOCTOR)
                .Select(doctor => new
                {
                    id = doctor.Worker_id,
                    name = doctor.First_name + " " + doctor.Last_name
                })
                .ToList();
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "id";
            if(userRole == Role.DOCTOR)
            {
                comboBox2.Visible = false;
                label4.Visible = false;
                comboBox2.SelectedValue = doctorID;
            }
            else
                comboBox2.SelectedItem = null;

            if (userRole == Role.DOCTOR)
            {
                bindingNavigatorAddNewItem.Visible = false;
                comboBox1.SelectedValue = "REJ";
            }
            else if(userRole == Role.REGISTRAR)
            {
                bindingNavigatorItemPerform.Visible = false;
                comboBox1.SelectedValue = "";
            }

            if(patientID!=0)
            {
                PatientData p = BizzLayer.Visits.getPatientById(patientID);
                textBox3.Enabled = false;
                textBox3.Text = p.PESEL;
                this.Text = "Wizyty dla: " + p.First_name + " " + p.Last_name;
            }
            LoadVisits();
        }
        private int CurrentRowID()
        {
            if (dataGridView1.SelectedRows.Count > 0)
                return (int)dataGridView1.SelectedRows[0].Cells["visitidDataGridViewTextBoxColumn"].Value;
            else
                return (int)dataGridView1.CurrentRow.Cells["visitidDataGridViewTextBoxColumn"].Value;
        }

        private void bindingNavigatorItemData_Click(object sender, EventArgs e)
        {
            int id = CurrentRowID();
            new VisitsAddWindow(ViewMode.VIEW, patientID, id).ShowDialog();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new VisitsAddWindow(ViewMode.CREATE, patientID).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadVisits();
        }

        private void LoadVisits()
        {
            visitBindingSource.DataSource = BizzLayer.Visits.Get(new VisitFilterParams
            {
                doctorID = (int?)comboBox2.SelectedValue,
                patientPESEL = textBox3.Text,
                status = (string)comboBox1.SelectedValue,
                dateFrom = dateTimePicker1.Checked ? dateTimePicker1.Value : (DateTime?)null,
                dateTo = dateTimePicker2.Checked ? dateTimePicker2.Value : (DateTime?)null
            }).Select(v => new
            {
                visit_id = v.visit_id,
                description = v.description,
                diagnosis = v.diagnosis,
                status = v.status,
                registration_date = v.registration_date,
                ending_date = v.ending_date,
                patient_id = v.patient_id,
                doctor_id = v.doctor_id,
                registrer_id = v.registerer_id
            }).ToList();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

            bool currentExists = (bindingNavigator1.BindingSource != null && bindingNavigator1.BindingSource.Current != null);

            bindingNavigatorEditItem.Enabled = currentExists;
            bindingNavigatorItemData.Enabled = currentExists;
            bindingNavigatorItemCancel.Enabled = currentExists;
            bindingNavigatorItemPerform.Enabled = currentExists;
        }

        private void bindingNavigatorItemPerform_Click(object sender, EventArgs e)
        {
            Visit visit = BizzLayer.Visits.GetByID(CurrentRowID());
            switch(visit.status)
            {
                case "REJ":
                    new VisitsPerformWindow(visit.visit_id).ShowDialog();
                    break;
                case "ANUL":
                    MainWindow.ShowError("Wizyta została anulowana.");
                    break;
                case "ZAK":
                    MainWindow.ShowError("Wizyta została zakończona.");
                    break;
            }
            LoadVisits();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
                comboBox2.SelectedIndex = -1;
            if (comboBox1.SelectedItem != null)
                comboBox1.SelectedIndex = -1;
        }

        private void bindingNavigatorItemCancel_Click(object sender, EventArgs e)
        {
            Visit visit = BizzLayer.Visits.GetByID(CurrentRowID());
            DialogResult result = MainWindow.ShowQuestion("Jesteś pewny, że chcesz anulować wizytę: " + Environment.NewLine + visit.Patient.First_name+" "+visit.Patient.Last_name, "Anulowanie wizyty");
            if(result==DialogResult.Yes)
            {
                BizzLayer.Visits.Cancel(visit.visit_id);
                LoadVisits();
            }
        }
    }
}
