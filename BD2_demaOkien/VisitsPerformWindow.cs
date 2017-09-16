using BD2_demaOkien.BizzLayer;
using BD2_demaOkien.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD2_demaOkien
{
    public partial class VisitsPerformWindow : Form
    {
        private int VisitId;
        private int PatientId;
        public VisitsPerformWindow(int visitId)
        {
            this.VisitId = visitId;
            InitializeComponent();
        }
        List<PhysicalExaminationData> oldPhysicalExaminations;
        List<LabExaminationData> oldLabExaminations;

        private void RefreshData()
        {
            labBindingSource.DataSource = BizzLayer.LabExaminations.Get(new ExaminationFilterParams
            {
                visit_id = this.VisitId
            }).ToList();
            phBindingSource.DataSource = BizzLayer.PhysicalExaminations.Get(new ExaminationFilterParams
            {
                visit_id = this.VisitId
            }).ToList();
            shortVisitBindingSource.DataSource = BizzLayer.Visits.Get(new VisitFilterParams
            {
                dateTo = DateTime.Today,
                patientId = PatientId
            }).Where(v => v.visit_id != this.VisitId).ToList();
            oldLabExaminations = BizzLayer.LabExaminations.Get(new ExaminationFilterParams
            {
                patient_id = PatientId
            }).ToList();
            oldPhysicalExaminations = BizzLayer.PhysicalExaminations.Get(new ExaminationFilterParams
            {
                patient_id = PatientId
            }).ToList();
        }
        private void VisitsPerformWindow_Load(object sender, EventArgs e)
        {
            Patient patient = BizzLayer.Visits.GetByID(VisitId).Patient;
            PatientId = patient.Patient_id;
            textBoxName.Text = patient.First_name;
            textBoxSurname.Text = patient.Last_name;
            textBoxPESEL.Text = patient.PESEL;
            RefreshData();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if(new ExaminationsAddWindow(ExaminationMode.PHYSICAL, VisitId).ShowDialog() == DialogResult.OK)
                RefreshData();
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            if (new ExaminationsAddWindow(ExaminationMode.LAB, VisitId).ShowDialog() == DialogResult.OK)
                RefreshData();
        }

        private void buttonPatientData_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void masterControl1_ApplyDetailFilter(object _key)
        {
            int key = (int)_key;
            shortPhBindingSource.DataSource = oldPhysicalExaminations.Where(ex => ex.visit_id == key).ToList();
            shortLabBindingSource.DataSource = oldLabExaminations.Where(ex => ex.visit_id == key).ToList();
        }

        private void dataGridView5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            if (dataGridView5.SelectedRows.Count > 0)
            {
                id = (int)dataGridView5.SelectedRows[0].Cells["lABexaminationidDataGridViewTextBoxColumn"].Value;
            }
            else
            {
                id = (int)dataGridView5.CurrentRow.Cells["lABexaminationidDataGridViewTextBoxColumn"].Value;
            }
            new ExaminationsDetailWindow(id).ShowDialog();
            
        }
    }

}
