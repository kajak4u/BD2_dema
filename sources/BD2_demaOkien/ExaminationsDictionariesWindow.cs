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
    public partial class ExaminationsDictionariesWindow : Form
    {
        public ExaminationsDictionariesWindow()
        {
            InitializeComponent();
        }

        private void ExaminationsDictionariesWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_2DataSet.Examination_dictionary' table. You can move, or remove it, as needed.
     //       this.examination_dictionaryTableAdapter.Fill(this.bD_2DataSet.Examination_dictionary);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new ExaminationsDictionariesDetails(ViewMode.CREATE).ShowDialog();
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            new ExaminationsDictionariesDetails(ViewMode.EDIT).ShowDialog();
        }
    }
}
