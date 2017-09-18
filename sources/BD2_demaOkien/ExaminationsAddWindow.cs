using BD2_demaOkien.BizzLayer;
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
	public partial class ExaminationsAddWindow : Form
	{
		private List<Data.Examination_dictionary> examinations;
		private ExaminationMode mode;
		int visitId;

		public ExaminationsAddWindow(ExaminationMode mode, int visitId)
		{
			InitializeComponent();
			InitControls(mode);
			this.mode = mode;
			this.visitId = visitId;
            examinations = BizzLayer.ExaminationsDictionary.Get(mode).ToList();
            comboBox1.DataSource = examinations;
            comboBox1.SelectedIndex = -1;
		}
		private void InitControls(ExaminationMode mode)
		{
			if (mode == ExaminationMode.LAB)
				label7.Text = "Notatki                      ";
			else
				label7.Text = "Wynik                        ";
		}

		private void buttonApply_Click(object sender, EventArgs e)
		{
            try
            {
                switch (mode)
                {
                    case ExaminationMode.LAB:
                        LabExaminations.Add(comboBox1.SelectedValue.ToString(), richTextBox1.Text, visitId);
                        break;
                    case ExaminationMode.PHYSICAL:
                        PhysicalExaminations.Add(comboBox1.SelectedValue.ToString(), richTextBox1.Text, visitId);
                        break;
                    default:
                        break;
                }
            }
            catch(EntityValidationErrorWrapper ex)
            {
                this.DialogResult = DialogResult.None;
                MainWindow.ShowError(ex.FullMessage);
                return;
            }			
			Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
            string code = (string)comboBox1.SelectedValue;
            string name = examinations
                .Where(ex => ex.Examination_code.Equals(code))
                .Select(ex => ex.Examination_name)
                .FirstOrDefault();
			textBox1.Text = name==null ? "" : name;
		}

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;
        }

        private void ExaminationsAddWindow_Load(object sender, EventArgs e)
        {
            comboBox1.Focus();
        }
    }
}
