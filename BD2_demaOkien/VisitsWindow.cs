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

        String visitStatus = "";

        public VisitsWindow(Role openedRole, int? id)
        {
            InitializeComponent();
            if(openedRole == Role.DOCTOR)
            {
                label4.Visible = false;
                comboBox2.Visible = false;
                comboBox2.SelectedValue = "/**current user**/";
                bindingNavigatorAddNewItem.Visible = false;
                this.comboBox1.SelectedText = "Zarejestrowane";
                LoadVisitDoctor((int)id.Value);
            }
            else if(openedRole == Role.REGISTRAR)
            {
                if (id.HasValue)
                {
                    PatientData p = Visit.getPatientById((int)id.Value);
                }
                textBox3.Enabled = false;
                textBox3.Text = "/**current patient**/";
                this.Text = "Wizyty dla: ";
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
                }
                LoadVisitRegister((int)id.Value);
            }
        }

        private void LoadVisitDoctor(int id) {
            using (var Db = new BD2_demaOkien.Data.BD2_2Db())
            {
                var visits = from visit in Db.Visit
                             join doctor in Db.Worker
                             on visit.doctor_id equals doctor.Worker_id
                             join patient in Db.Patient
                             on visit.patient_id equals patient.Patient_id
                             join register in Db.Worker
                             on visit.registerer_id equals register.Worker_id
                             where doctor.Worker_id== id
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


private void LoadVisitRegister(int id) {
    using (var Db = new BD2_demaOkien.Data.BD2_2Db())
    {
            var visits = from visit in Db.Visit
                         join doctor in Db.Worker
                         on visit.doctor_id equals doctor.Worker_id
                         join patient in Db.Patient
                         on visit.patient_id equals patient.Patient_id
                         join register in Db.Worker
                         on visit.registerer_id equals register.Worker_id
                         where patient.Patient_id == id
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
            dateTimePicker1.Value = dateTimePicker2.Value = DateTime.Now;
        }

        private void bindingNavigatorItemData_Click(object sender, EventArgs e)
        {
            new VisitsAddWindow(ViewMode.VIEW).ShowDialog();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new VisitsAddWindow(ViewMode.CREATE).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.visitTableAdapter.Fill(this.bD_2DataSet.Visit);
            //TODO: filtry
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
            String doctor_name = comboBox2.SelectedItem.ToString();
            MessageBox.Show(doctor_name, "Wyjątek!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {

        }



    }
}
