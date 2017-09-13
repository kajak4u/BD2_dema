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

        private void VisitsPerformWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_2DataSet.ShortPhysicalExaminations' table. You can move, or remove it, as needed.
            this.shortPhysicalExaminationsTableAdapter.Fill(this.bD_2DataSet.ShortPhysicalExaminations);
            // TODO: This line of code loads data into the 'bD_2DataSet.ShortLABExaminations' table. You can move, or remove it, as needed.
            this.shortLABExaminationsTableAdapter.Fill(this.bD_2DataSet.ShortLABExaminations);
            // TODO: This line of code loads data into the 'bD_2DataSet.ShortVisit' table. You can move, or remove it, as needed.
            this.shortVisitTableAdapter.Fill(this.bD_2DataSet.ShortVisit);
            // TODO: This line of code loads data into the 'bD_2DataSet.Visit' table. You can move, or remove it, as needed.
            this.visitTableAdapter.Fill(this.bD_2DataSet.Visit);
            // TODO: This line of code loads data into the 'bD_2DataSet.LAB_examination' table. You can move, or remove it, as needed.
            this.lAB_examinationTableAdapter.Fill(this.bD_2DataSet.LAB_examination);
            // TODO: This line of code loads data into the 'bD_2DataSet.Physical_examination' table. You can move, or remove it, as needed.
            this.physical_examinationTableAdapter.Fill(this.bD_2DataSet.Physical_examination);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new ExaminationsAddWindow(ExaminationMode.PHYSICAL).ShowDialog(); //potrzebne jest ID_wizyty jako drugi param
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            new ExaminationsAddWindow(ExaminationMode.LAB).ShowDialog();
        }

        private void buttonPatientData_Click(object sender, EventArgs e)
        {
        }
    }
}
