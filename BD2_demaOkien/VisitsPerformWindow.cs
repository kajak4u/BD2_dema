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
                dateTo = DateTime.Today
            }).Where(v => v.visit_id != this.VisitId).ToList();
            oldLabExaminations = BizzLayer.LabExaminations.Get(new ExaminationFilterParams
            {
                patient_id = PatientId
            }).ToList();
            oldPhysicalExaminations = BizzLayer.PhysicalExaminations.Get(new ExaminationFilterParams
            {
                patient_id = PatientId
            }).ToList();
            using (BD2_2Db Db = new BD2_2Db())
            {
                phBindingSource.DataSource = Db.Physical_examination.Select(ex => new PhysicalExaminationData
                {
                    Physical_Examination_Id = ex.Physical_examination_id,
                    Physical_examination_code = ex.Physical_examination_code,
                    Result = ex.Result,
                    Nazwa = ex.Examination_dictionary.Examination_name
                }).ToList();
                labBindingSource.DataSource = Db.LAB_examination
                    .Include(ex => ex.Examination_dictionary)
                    .Include(ex => ex.Visit)
                    .Include(ex => ex.Worker)
                    .Include(ex => ex.Worker1)
                    .Select(ex => new LabExaminationData
                    {
                        commission_examination_date = ex.commission_examination_date,
                        doctor_notes = ex.doctor_notes,
                        ending_examination_date = ex.ending_examination_date,
                        LAB_examination_code = ex.LAB_examination_code,
                        LAB_examination_date = ex.LAB_examination_date,
                        LAB_examination_id = ex.LAB_examination_id,
                        LAB_examination_result = ex.LAB_examination_result,
                        LAB_manager_id = ex.LAB_manager_id,
                        LAB_manager_notes = ex.LAB_manager_notes,
                        LAB_worker_id = ex.LAB_worker_id,
                        status = ex.status,
                        Visit = ex.Visit,
                        visit_id = ex.visit_id,
                        Nazwa = ex.Examination_dictionary.Examination_name,
                        Lab = ex.Worker.First_name + " " + ex.Worker.Last_name,
                        Klab = ex.Worker1.First_name + " " + ex.Worker1.Last_name
                    }).ToList();
                shortVisitBindingSource.DataSource = BizzLayer.Visits.GetAll().ToList();
                oldPhysicalExaminations = Db.Physical_examination.Select(ex => new PhysicalExaminationData
                {
                    visit_id = ex.visit_id,
                    Physical_Examination_Id = ex.Physical_examination_id,
                    Physical_examination_code = ex.Physical_examination_code,
                    Result = ex.Result,
                    Nazwa = ex.Examination_dictionary.Examination_name
                }).ToList();
                shortPhBindingSource.DataSource = oldPhysicalExaminations;
                oldLabExaminations = Db.LAB_examination
                    .Include(ex => ex.Examination_dictionary)
                    .Include(ex => ex.Visit)
                    .Include(ex => ex.Worker)
                    .Include(ex => ex.Worker1)
                    .Select(ex => new LabExaminationData
                    {
                        commission_examination_date = ex.commission_examination_date,
                        doctor_notes = ex.doctor_notes,
                        ending_examination_date = ex.ending_examination_date,
                        LAB_examination_code = ex.LAB_examination_code,
                        LAB_examination_date = ex.LAB_examination_date,
                        LAB_examination_id = ex.LAB_examination_id,
                        LAB_examination_result = ex.LAB_examination_result,
                        LAB_manager_id = ex.LAB_manager_id,
                        LAB_manager_notes = ex.LAB_manager_notes,
                        LAB_worker_id = ex.LAB_worker_id,
                        status = ex.status,
                        Visit = ex.Visit,
                        visit_id = ex.visit_id,
                        Nazwa = ex.Examination_dictionary.Examination_name,
                        Lab = ex.Worker.First_name + " " + ex.Worker.Last_name,
                        Klab = ex.Worker1.First_name + " " + ex.Worker1.Last_name
                    }).ToList();
                shortLabBindingSource.DataSource = oldLabExaminations;

            }
        }
        private void VisitsPerformWindow_Load(object sender, EventArgs e)
        {
            PatientId = BizzLayer.Visits.GetByID(VisitId).patient_id;
            // TODO: This line of code loads data into the 'bD_2DataSet.ShortPhysicalExaminations' table. You can move, or remove it, as needed.
            //this.shortPhysicalExaminationsTableAdapter.Fill(this.bD_2DataSet.ShortPhysicalExaminations);
            //// TODO: This line of code loads data into the 'bD_2DataSet.ShortLABExaminations' table. You can move, or remove it, as needed.
            //this.shortLABExaminationsTableAdapter.Fill(this.bD_2DataSet.ShortLABExaminations);
            //// TODO: This line of code loads data into the 'bD_2DataSet.ShortVisit' table. You can move, or remove it, as needed.
            //this.shortVisitTableAdapter.Fill(this.bD_2DataSet.ShortVisit);
            //// TODO: This line of code loads data into the 'bD_2DataSet.Visit' table. You can move, or remove it, as needed.
            //this.visitTableAdapter.Fill(this.bD_2DataSet.Visit);
            //// TODO: This line of code loads data into the 'bD_2DataSet.LAB_examination' table. You can move, or remove it, as needed.
            //this.lAB_examinationTableAdapter.Fill(this.bD_2DataSet.LAB_examination);
            //// TODO: This line of code loads data into the 'bD_2DataSet.Physical_examination' table. You can move, or remove it, as needed.
            //this.physical_examinationTableAdapter.Fill(this.bD_2DataSet.Physical_examination);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new ExaminationsAddWindow(ExaminationMode.PHYSICAL, 0).ShowDialog(); //potrzebne jest ID_wizyty jako drugi param
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            new ExaminationsAddWindow(ExaminationMode.LAB, 0).ShowDialog();
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
