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

namespace BD2_demaOkien
{
    public partial class VisitsPerformWindow : Form
    {
        public VisitsPerformWindow()
        {
            InitializeComponent();
        }
        List<Physical_examination> oldPhysicalExaminations;
        List<LAB_examination> oldLabExaminations;

        private void VisitsPerformWindow_Load(object sender, EventArgs e)
        {
            using (BD2_2Db Db = new BD2_2Db())
            {
                phBindingSource.DataSource = Db.Physical_examination.Select(ex => new
                {
                    Physical_examination_code = ex.Physical_examination_code,
                    Result = ex.Result,
                    Nazwa = ex.Examination_dictionary.Examination_name
                }).ToList();
                labBindingSource.DataSource = Db.LAB_examination.Select(ex => new
                {
                    Lab_Examination_code = ex.LAB_examination_code,
                    Doctor_Notes = ex.doctor_notes,
                    Nazwa = ex.Examination_dictionary.Examination_name
                }).ToList();
                shortVisitBindingSource.DataSource = Db.Visit.ToList();
                oldPhysicalExaminations = Db.Physical_examination.ToList();
                shortPhBindingSource.DataSource = oldPhysicalExaminations;
                oldLabExaminations = Db.LAB_examination.ToList();
                shortLabBindingSource.DataSource = oldLabExaminations;

            }
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
    }
}
