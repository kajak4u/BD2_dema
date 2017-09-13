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
        private String visitStatus = null;

        public VisitsWindow(Role openedRole, int? id)
        {
           
            userRole = openedRole;
            InitializeComponent();
            if(openedRole == Role.DOCTOR)
            {
                doctorID = (int)id.Value;
                label4.Visible = false;
                comboBox2.Visible = false;
                comboBox2.SelectedValue = "/**current user**/";
                bindingNavigatorAddNewItem.Visible = false;
                this.comboBox1.SelectedText = "Zarejestrowane";
                LoadVisitDoctor();
               
            }
            else if(openedRole == Role.REGISTRAR)
            {
                PatientData p = null;
                if (id.HasValue)
                {
                    p = BizzLayer.Visits.getPatientById((int)id.Value);
                }
                patientID = id.Value;
                textBox3.Enabled = false;
                textBox3.Text = p.PESEL;
                this.Text = "Wizyty dla: " + p.First_name + " "+ p.Last_name;
                bindingNavigatorItemPerform.Visible = false;
                using (var Db = new BD2_demaOkien.Data.BD2_2Db())
                {
                    var doctors = from doctor in Db.Worker
                                  where doctor.Role.ToUpper() == "DOCTOR"
                                  select new
                                  {
                                      id = doctor.Worker_id,
                                      name = doctor.First_name.ToString() + " " + doctor.Last_name.ToString()
                                  };
                    comboBox2.DataSource = doctors.Select(a=> a.name).ToList();
                    comboBox2.SelectedItem = null;
                }
                LoadVisitRegister();
            }
        }

        private void LoadVisitDoctor() {
            using (var Db = new BD2_demaOkien.Data.BD2_2Db())
            {
                var visits = from visit in Db.Visit
                             join doctor in Db.Worker
                             on visit.doctor_id equals doctor.Worker_id
                             join patient in Db.Patient
                             on visit.patient_id equals patient.Patient_id
                             join register in Db.Worker
                             on visit.registerer_id equals register.Worker_id
                             where doctor.Worker_id== doctorID
                             select new
                             {
                                 visit_id = visit.visit_id,
                                 status = visit.status,
                                 description = visit.description,
                                 diagnosis = visit.diagnosis,
                                 registration_date = visit.registration_date,
                                 ending_date = visit.ending_date,
                                 patientId = patient.Patient_id,
                                 patient_id = patient.First_name + " " + patient.Last_name,
                                 doctorId = doctor.Worker_id,
                                 doctor_id = doctor.First_name + " " + doctor.Last_name,
                                 registerId = register.Worker_id,
                                 registerer_id = register.First_name + " " + register.Last_name
                             };
                visitBindingSource.DataSource = visits.ToList();
            }
        }


private void LoadVisitRegister() {
    using (var Db = new BD2_demaOkien.Data.BD2_2Db())
    {
            var visits = from visit in Db.Visit
                         join doctor in Db.Worker
                         on visit.doctor_id equals doctor.Worker_id
                         join patient in Db.Patient
                         on visit.patient_id equals patient.Patient_id
                         join register in Db.Worker
                         on visit.registerer_id equals register.Worker_id
                         where patient.Patient_id == patientID
                         select new
                         {
                             visit_id = visit.visit_id,
                             status = visit.status,
                             description = visit.description,
                             diagnosis = visit.diagnosis,
                             registration_date = visit.registration_date,
                             ending_date = visit.ending_date,
                             patientId = patient.Patient_id,
                             patient_id = patient.First_name + " " + patient.Last_name,
                             doctorId = doctor.Worker_id,
                             doctor_id = doctor.First_name + " " + doctor.Last_name,
                             registerId = register.Worker_id,
                             registerer_id = register.First_name + " " + register.Last_name
                         };
            visitBindingSource.DataSource = visits.ToList();
    }
}

        private void LoadVisitRegisterWithFilters()
        {
            using (var Db = new BD2_demaOkien.Data.BD2_2Db())
            {
                var visits = from visit in Db.Visit
                             join doctor in Db.Worker
                             on visit.doctor_id equals doctor.Worker_id
                             join patient in Db.Patient
                             on visit.patient_id equals patient.Patient_id
                             join register in Db.Worker
                             on visit.registerer_id equals register.Worker_id
                             where (patient.Patient_id == patientID) 
                                && ((visitStatus == null ? visitStatus== null : visit.status.Equals(visitStatus)))
                             select new
                             {
                                 visit_id = visit.visit_id,
                                 status = visit.status,
                                 description = visit.description,
                                 diagnosis = visit.diagnosis,
                                 registration_date = visit.registration_date,
                                 ending_date = visit.ending_date,
                                 patientId = patient.Patient_id,
                                 patient_id = patient.First_name + " " + patient.Last_name,
                                 doctorId = doctor.Worker_id,
                                 doctor_id = doctor.First_name + " " + doctor.Last_name,
                                 registerId = register.Worker_id,
                                 registerer_id = register.First_name + " " + register.Last_name
                             };
                visitBindingSource.DataSource = visits.ToList();
            }
        }

        private void VisitsWindow_Load(object sender, EventArgs e)
        {
            bool ch1 = dateTimePicker1.Checked,
                ch2 = dateTimePicker2.Checked;
            dateTimePicker1.Value = dateTimePicker2.Value = DateTime.Now;
            dateTimePicker1.Checked = ch1;
            dateTimePicker2.Checked = ch2;
        }

        private void bindingNavigatorItemData_Click(object sender, EventArgs e)
        {
            int id;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = (int)dataGridView1.SelectedRows[0].Cells["visitidDataGridViewTextBoxColumn"].Value;
            }
            else
            {
                id = (int)dataGridView1.CurrentRow.Cells["visitidDataGridViewTextBoxColumn"].Value;
            }
            new VisitsAddWindow(ViewMode.VIEW, patientID, id).ShowDialog();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new VisitsAddWindow(ViewMode.CREATE, patientID).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.visitTableAdapter.Fill(this.bD_2DataSet.Visit);
            //TODO: filtry
            LoadVisitRegisterWithFilters();
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
            new VisitsPerformWindow().ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String doctor_name = comboBox2.SelectedItem.ToString();
            //MessageBox.Show("doctoridDataGridViewTextBoxColumn:", "Wyjątek!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString()) {
                case ("Wszystkie"):
                    visitStatus = null;
                    break;
                case ("Zarejestrowane"):
                    visitStatus = "REJ";
                    break;
                case ("Odbyte"):
                    visitStatus = "ZAK";
                    break;
                case ("Anulowane"):
                    visitStatus = "ANUL";
                    break;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {

        }
    }
}
