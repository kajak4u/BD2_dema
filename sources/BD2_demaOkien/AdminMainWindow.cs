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
    public partial class AdminMainWindow : Form
    {
        private bool selectMode;
        public AdminMainWindow(bool selectMode=false)
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
            //bindingNavigatorItemVisits.Enabled = currentExists;
            //bindingNavigatorItemTests.Enabled = currentExists;
            //bindingNavigatorItemAddVisit.Enabled = currentExists;
            //var deleteItem = bindingNavigator1.Items.Find("bindingNavigatorDeleteItem", false);
            //deleteItem.First().Enabled = currentExists;
        }

        private void Workers_Load(object sender, EventArgs e)
        {
            //LoadWorkers();
        }

        private void LoadWorkers()
        {
            String Rola = "";
            if (comboBox2.SelectedItem != null && comboBox2.SelectedIndex != -1) {
                switch (comboBox2.SelectedItem.ToString()) {
                    case ("Rejestrator"):
                        Rola = "registrar";
                        break;
                    case ("Lekarz"):
                        Rola = "doctor";
                        break;
                    case ("Laborant"):
                        Rola = "lab";
                        break;
                    case ("Kierownik laboratorium"):
                        Rola = "klab";
                        break;
                    case ("Administrator"):
                        Rola = "admin";
                        break;
                }
            }

            using (var Db = new Data.BD2_2Db())
            {
                var worker = from workers in Db.Worker
                              where workers.First_name.Contains(textBox1.Text) && workers.Last_name.Contains(textBox2.Text) && workers.Role.Contains(Rola)//FirstName == patients.First_name && LastName == patients.Last_name //&& Pesel == patients.PESEL
                              select new
                              {
                                  WorkerId = workers.Worker_id,
                                  First_name = workers.First_name,
                                  Last_name = workers.Last_name,
                                  Phone_number = workers.Phone_number,
                                  PESEL = workers.PESEL,
                                  Role = workers.Role,
                                  Expiration = workers.Expiration_date
                              };
                patientBindingSource.DataSource = worker.ToList();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new WorkerDetailsWindow(ViewMode.CREATE, 0).ShowDialog();
            LoadWorkers();
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            int id = CurrentRecordID();
            new WorkerDetailsWindow(ViewMode.EDIT, id).ShowDialog();
            this.LoadWorkers();

        }

        private int CurrentRecordID()
        {
            int id;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = (int)dataGridView1.SelectedRows[0].Cells["WorkerId"].Value;
            }
            else
            {
                id = (int)dataGridView1.CurrentRow.Cells["WorkerId"].Value;
            }
            return id;
        }

        private void bindingNavigatorItemData_Click(object sender, EventArgs e)
        {
            int id = CurrentRecordID();
            new WorkerDetailsWindow(ViewMode.VIEW, id).ShowDialog();
            LoadWorkers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadWorkers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            if (comboBox2.SelectedItem != null)
                comboBox2.SelectedIndex = -1;
        }

    } 
}
