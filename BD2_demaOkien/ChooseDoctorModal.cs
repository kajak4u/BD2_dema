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
    public partial class ChooseDoctorModal : Form
    {
        private string chosenDoctor; //TODO : change to class Worker
        public string ChosenDoctor { get { return chosenDoctor; } }
        public ChooseDoctorModal()
        {
            InitializeComponent();
        }
        private void SetCurrentRow(int rowIndex)
        {
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            if (row == null)
                return;
            chosenDoctor = row.Cells["First_Name"].Value.ToString();
            chosenDoctor += " ";
            chosenDoctor += row.Cells["Last_Name"].Value.ToString();
        }

        private void ChooseDoctorModal_Load(object sender, EventArgs e)
        {
            //this.workerBindingSource
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SetCurrentRow(e.RowIndex);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCurrentRow(e.RowIndex);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
