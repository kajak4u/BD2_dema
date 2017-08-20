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
        public VisitsWindow(Role openedRole)
        {
            InitializeComponent();
            if(openedRole == Role.DOCTOR)
            {
                label4.Visible = false;
                comboBox2.Visible = false;
                comboBox2.SelectedValue = "/**current user**/";
                bindingNavigatorAddNewItem.Visible = false;
                this.comboBox1.SelectedText = "Zarejestrowane";
            }
            else if(openedRole == Role.REGISTRAR)
            {
                textBox3.Enabled = false;
                textBox3.Text = "/**current patient**/";
                this.Text = "Wizyty dla: ";
                bindingNavigatorItemPerform.Visible = false;
            }

            using (var Db = new BD2_demaOkien.Data.BD2_2Db())
            {
                var visits = from visit in Db.Visit
                             join doctor in Db.Worker
                             on visit.doctor_id equals doctor.Worker_id
                             where visit.visit_id == 1
                             join patient in Db.Patient
                             on visit.patient_id equals patient.Patient_id
                             join register in Db.Worker
                             on visit.registerer_id equals register.Worker_id
                             select new
                             {
                                 visit.status,
                                 visit.registration_date,
                                 visit.ending_date,
                                 Patient = patient.First_name,
                                 Doctor = doctor.First_name,
                                 Register = register.First_name
                             };

                var worker = Db.Visit.ToList().Where(v => v.visit_id == 1)
                    .Select(v => v.Worker).FirstOrDefault();

                // zapis
                worker.First_name = "Zenek";
                Db.SaveChanges();

                var workerName = worker.Address.Street;

                dataGridView1.DataSource = visits.ToList();
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
    }
}
