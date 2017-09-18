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
//using BD2_demaOkien.BizzLayer;

namespace BD2_demaOkien
{
    public partial class AdminMainWindow : Form
    {
        public AdminMainWindow()
        {
            InitializeComponent();
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
            ((MainWindow)this.MdiParent).RegisterMDI(this, OnDuplicateAction.CloseThis);
            comboBox2.DataSource = UserRole.roleDictionary
                .ToList();
            comboBox2.SelectedValue = "";
            LoadWorkers();
        }

        private void LoadWorkers()
        {
            patientBindingSource.DataSource = BizzLayer.Workers
                .Get(new UserFilterParams
                {
                    First_Name = textBox1.Text,
                    Last_Name = textBox2.Text,
                    Role = (string)comboBox2.SelectedValue
                })
                .Select(worker => new
                {
                    WorkerId = worker.Worker_id,
                    First_name = worker.First_name,
                    Last_name = worker.Last_name,
                    Phone_number = worker.Phone_number,
                    PESEL = worker.PESEL,
                    Role = worker.Role,
                    Expiration = worker.Expiration_date
                }).ToList();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new WorkerDetailsWindow(ViewMode.CREATE, null).ShowDialog();
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
            comboBox2.SelectedValue = "";
        }

    }
}
