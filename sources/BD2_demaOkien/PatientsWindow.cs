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
//using BD2_demaOkien.BizzLayer;

namespace BD2_demaOkien
{
    public partial class PatientsWindow : Form
    {
        private bool selectMode;
        public PatientsWindow(bool selectMode=false)
        {
            this.selectMode = selectMode;
            InitializeComponent();
            if(selectMode)
            {
                bindingNavigator1.Visible = false;
                bindingNavigator_selectMode.Visible = true;
            }
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {
            bool currentExists = (bindingNavigator1.BindingSource != null && bindingNavigator1.BindingSource.Current != null);

            bindingNavigatorEditItem.Enabled = currentExists;
            bindingNavigatorItemData.Enabled = currentExists;
            bindingNavigatorItemVisits.Enabled = currentExists;
            bindingNavigatorItemTests.Enabled = currentExists;
            bindingNavigatorItemAddVisit.Enabled = currentExists;
            var deleteItem = bindingNavigator1.Items.Find("bindingNavigatorDeleteItem", false);
            deleteItem.First().Enabled = currentExists;
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void LoadPatients()
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
                                  Address = address.Flat_number != null ? address.City + ", " + address.Street + " " + address.House_number + "/" + address.Flat_number : address.City + ", " + address.Street + " " + address.House_number
                              };
                patientBindingSource.DataSource = patient.ToList();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new PatientDetailsWindow(ViewMode.CREATE, 0).ShowDialog();
            LoadPatients();
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            int id = CurrentRecordID();
            new PatientDetailsWindow(ViewMode.EDIT, id).ShowDialog();
            this.LoadPatients();

        }

        private void bindingNavigatorItemVisits_Click(object sender, EventArgs e)
        {
            int id = CurrentRecordID();
            VisitsWindow visits = new VisitsWindow(id);
            visits.MdiParent = this.MdiParent;
            visits.Show();
        }
        private int CurrentRecordID()
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
            return id;
        }

        private void bindingNavigatorItemData_Click(object sender, EventArgs e)
        {
            int id = CurrentRecordID();
            new PatientDetailsWindow(ViewMode.VIEW, id).ShowDialog();
            LoadPatients();
        }

        private void bindingNavigatorItemTests_Click(object sender, EventArgs e)
        {
            ExaminationsWindow examinations = new ExaminationsWindow
            {
                patientId = CurrentRecordID()
            };
            examinations.MdiParent = this.MdiParent;
            examinations.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int id = CurrentRecordID();
            new VisitsAddWindow(ViewMode.CREATE, id).ShowDialog();
            LoadPatients();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MainWindow.ShowQuestion("Jesteś pewny, że chcesz usunąć pacjenta: " + Environment.NewLine + dataGridView1.CurrentRow.Cells[1].Value + " " + dataGridView1.CurrentRow.Cells[2].Value, "Usuwanie użytkownika"))
            {
                int id = CurrentRecordID();
                BizzLayer.Visits.deleteUser(id);
                LoadPatients();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void toolStripButtonSelect_Click(object sender, EventArgs e)
        {
            Patient patient = BizzLayer.Patients.GetByID(CurrentRecordID());
            if(patient==null)
            {
                MainWindow.ShowError("Nie wybrano pacjenta!");
                return;
            }
            MainWindow.LastSelectResult = patient.PESEL;
            Close();
        }

        private void toolStripButtonNoSelect_Click(object sender, EventArgs e)
        {
            MainWindow.LastSelectResult = null;
            Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectMode)
                toolStripButtonSelect_Click(sender, e);
        }
    } 
}
