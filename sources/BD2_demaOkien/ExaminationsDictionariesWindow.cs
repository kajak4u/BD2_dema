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
        private ExaminationMode? type=null;
        public ExaminationsDictionariesWindow()
        {
            InitializeComponent();
        }

        private void ExaminationsDictionariesWindow_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;
            RefreshData();
            // TODO: This line of code loads data into the 'bD_2DataSet.Examination_dictionary' table. You can move, or remove it, as needed.
            //       this.examination_dictionaryTableAdapter.Fill(this.bD_2DataSet.Examination_dictionary);
        }
        private void RefreshData()
        {
            examinationdictionaryBindingSource.DataSource = BizzLayer.ExaminationsDictionary.Get(type);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new ExaminationsDictionariesDetails(ViewMode.CREATE, null, type).ShowDialog();
            RefreshData();
        }
        private string CurrentRecordID()
        {
            string id;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = (string)dataGridView1.SelectedRows[0].Cells["examinationcodeDataGridViewTextBoxColumn"].Value;
            }
            else
            {
                id = (string)dataGridView1.CurrentRow.Cells["examinationcodeDataGridViewTextBoxColumn"].Value;
            }
            return id;
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            new ExaminationsDictionariesDetails(ViewMode.EDIT, CurrentRecordID()).ShowDialog();
            RefreshData();
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    type = null;
                    break;
                case 1:
                    type = ExaminationMode.PHYSICAL;
                    break;
                case 2:
                    type = ExaminationMode.LAB;
                    break;
                default:
                    break;
            }
            RefreshData();
        }
    }
}
