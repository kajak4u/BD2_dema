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
            // TODO: This line of code loads data into the 'bD_2DataSet.VisitsWithExaminations' table. You can move, or remove it, as needed.
            this.visitsWithExaminationsTableAdapter.Fill(this.bD_2DataSet.VisitsWithExaminations);
            // TODO: This line of code loads data into the 'bD_2DataSet.Visit' table. You can move, or remove it, as needed.
            this.visitTableAdapter.Fill(this.bD_2DataSet.Visit);
            // TODO: This line of code loads data into the 'bD_2DataSet.LAB_examination' table. You can move, or remove it, as needed.
            this.lAB_examinationTableAdapter.Fill(this.bD_2DataSet.LAB_examination);
            // TODO: This line of code loads data into the 'bD_2DataSet.Physical_examination' table. You can move, or remove it, as needed.
            this.physical_examinationTableAdapter.Fill(this.bD_2DataSet.Physical_examination);

            this.masterControl1.setParentSource(this.bD_2DataSet.Visit.TableName, "visit_id");
            this.masterControl1.childView.Add(this.bD_2DataSet.Physical_examination.TableName, "Badania fizyczne");
            this.masterControl1.childView.Add(this.bD_2DataSet.LAB_examination.TableName, "Badania laboratoryjne");
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new ExaminationsAddWindow(ExaminationMode.PHYSICAL).ShowDialog();
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            new ExaminationsAddWindow(ExaminationMode.LAB).ShowDialog();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
