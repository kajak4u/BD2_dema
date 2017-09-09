using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using BD2_demaOkien.BizzLayer;

namespace BD2_demaOkien
{
    public partial class PatientsWindow : Form
    {

        private int selectedPatientId = 0;

        public PatientsWindow()
        {
            InitializeComponent();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {
            bool currentExists = (bindingNavigator1.BindingSource != null && bindingNavigator1.BindingSource.Current != null);

            bindingNavigatorEditItem.Enabled = currentExists;
            bindingNavigatorItemData.Enabled = currentExists;
            bindingNavigatorItemVisits.Enabled = currentExists;
            bindingNavigatorItemTests.Enabled = currentExists;
            bindingNavigatorItemAddVisit.Enabled = currentExists;
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            this.LoadPatients();
            // TODO: This line of code loads data into the 'bD_2DataSet.Visit' table. You can move, or remove it, as needed.
            //this.visitTableAdapter.Fill(this.bD_2DataSet.Visit);
            // TODO: This line of code loads data into the 'bD_2DataSet.Patient' table. You can move, or remove it, as needed.
            //this.patientTableAdapter.Fill(this.bD_2DataSet.Patient);
            //var bindingList = new BindingList<AllPatientsData>(Visit.getAllPatients().ToList());
            //var source = new BindingSource(bindingList, null);
            //grid.DataSource = source
            //Visit.getAllPatients();//.ToList();
               // dataGridView1.Rows[1].Selected = true;
                //var patients = Db.Patient.ToList();

            //List<AllPatientsData> patients = Visit.getAllPatients();
            //dataGridView1.DataSource = patients.ToList();
        }

        private void LoadPatients()
        {
            using (var Db = new Data.BD2_2Db())
            {
                var patients = from patient in Db.Patient
                               join address in Db.Address
                               on patient.address_id equals address.Address_id
                               select new
                               {
                                   Patient_id = patient.Patient_id,
                                   First_name = patient.First_name,
                                   Last_name = patient.Last_name,
                                   PESEL = patient.PESEL,
                                   Phone_number = patient.Phone_number,
                                   Address = address.Flat_number != null ? address.City + " " + address.Street + " " + address.House_number + " " + address.Flat_number : address.City + " " + address.Street + " " + address.House_number
                               };
                patientBindingSource.DataSource = patients.ToList();
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.patientTableAdapter.Fill(this.bD_2DataSet.Patient);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new PatientDetailsWindow(ViewMode.CREATE, 0).ShowDialog();
            LoadPatients();
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            int id;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = (int)dataGridView1.SelectedRows[0].Cells["patientidDataGridViewTextBoxColumn"].Value;
            }
            else
            {
                id = (int)dataGridView1.CurrentRow.Cells["patientidDataGridViewTextBoxColumn"].Value;
            }
            new PatientDetailsWindow(ViewMode.EDIT, id).ShowDialog();
            this.LoadPatients();

        }

        private void bindingNavigatorItemVisits_Click(object sender, EventArgs e)
        {
            VisitsWindow visits = new VisitsWindow(Role.REGISTRAR);
            visits.MdiParent = this.MdiParent;
            visits.Show();
        }

        private void bindingNavigatorItemData_Click(object sender, EventArgs e)
        {
            int id;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = (int)dataGridView1.SelectedRows[0].Cells["patientidDataGridViewTextBoxColumn"].Value;
            }
            else
            {
                id = (int)dataGridView1.CurrentRow.Cells["patientidDataGridViewTextBoxColumn"].Value;
            }
                new PatientDetailsWindow(ViewMode.VIEW, id).ShowDialog();
            LoadPatients();
        }

        private void bindingNavigatorItemTests_Click(object sender, EventArgs e)
        {
            ExaminationsWindow examinations = new ExaminationsWindow();
            examinations.MdiParent = this.MdiParent;
            examinations.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new VisitsAddWindow(ViewMode.CREATE).ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {


            using (var Db = new Data.BD2_2Db())
            {
                var patient = from patients in Db.Patient
                              join address in Db.Address
                              on patients.address_id equals address.Address_id
                              where patients.First_name.Contains(textBox1.Text) && patients.Last_name.Contains(textBox2.Text) && patients.PESEL.Contains(textBox3.Text)//FirstName == patients.First_name && LastName == patients.Last_name //&& Pesel == patients.PESEL
                              select new
                              {
                                  Patient_id = patients.Patient_id,
                                  First_name = patients.First_name,
                                  Last_name = patients.Last_name,
                                  Phone_number = patients.Phone_number,
                                  PESEL = patients.PESEL,
                                  Address = address.Flat_number != null ? address.City + " " + address.Street + " " + address.House_number + " " + address.Flat_number : address.City + " " + address.Street + " " + address.House_number
                              };
                //var patients = Db.Patient.ToList();
                dataGridView1.DataSource =  patient.ToList();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            LoadPatients();
            DialogResult result = MessageBox.Show("Jesteś pewny, że chcesz usunąć pacjenta: " + Environment.NewLine + dataGridView1.CurrentRow.Cells[1].Value + " " + dataGridView1.CurrentRow.Cells[2].Value, "Usuwanie użytkownika", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                int id;
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    id = (int)dataGridView1.SelectedRows[0].Cells["patientidDataGridViewTextBoxColumn"].Value;
                }
                else
                {
                    id = (int)dataGridView1.CurrentRow.Cells["patientidDataGridViewTextBoxColumn"].Value;
                }
                Visit.deleteUser(id);
                LoadPatients();
            }
        }


        /* private void MoveToLinked(DataGridViewCellEventArgs e)
         {
             string employeeId;
             object value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
             if (value is DBNull) { return; }

             employeeId = value.ToString();
             DataGridViewCell boss = RetrieveSuperiorsLastNameCell(employeeId);
             if (boss != null)
             {
                 dataGridView1.CurrentCell = boss;
             }
         }

         private bool IsANonHeaderLinkCell(DataGridViewCellEventArgs cellEvent)
         {
             if (dataGridView1.Columns[cellEvent.ColumnIndex] is
                 DataGridViewLinkColumn &&
                 cellEvent.RowIndex != -1)
             { return true; }
             else { return false; }
         }

         private bool IsANonHeaderButtonCell(DataGridViewCellEventArgs cellEvent)
         {
             if (dataGridView1.Columns[cellEvent.ColumnIndex] is
                 DataGridViewButtonColumn &&
                 cellEvent.RowIndex != -1)
             { return true; }
             else { return (false); }
         }

         private DataGridViewCell RetrieveSuperiorsLastNameCell(string employeeId)
         {

             foreach (DataGridViewRow row in DataGridView1.Rows)
             {
                 if (row.IsNewRow) { return null; }
                 if (row.Cells[ColumnName.EmployeeId.ToString()].Value.ToString().Equals(employeeId))
                 {
                     return row.Cells[ColumnName.LastName.ToString()];
                 }
             }
             return null;
         }*/
    } 
}
