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
        public int doctorId { get; private set; }
        public ChooseDoctorModal()
        {
            doctorId = 0;
            InitializeComponent();
        }
        private void SetCurrentRow(int rowIndex)
        {
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            if (row == null)
                return;
            doctorId = (int)row.Cells["workeridDataGridViewTextBoxColumn"].Value;
        }

        private void ChooseDoctorModal_Load(object sender, EventArgs e)
        {
            workerBindingSource1.DataSource = BizzLayer.Workers.GetAll(Role.DOCTOR);
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
