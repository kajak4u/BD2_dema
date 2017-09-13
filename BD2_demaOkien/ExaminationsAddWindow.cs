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
		private List<String> examCodes;
		private List<String> examNames;
		private ExaminationMode mode;
		int visitId;

		public ExaminationsAddWindow(ExaminationMode mode, int visitId)
		{
			examCodes = new List<string>();
			examNames = new List<string>();
			InitializeComponent();
			InitControls(mode);
			this.mode = mode;
			this.visitId = visitId;

			using (var Db = new BD2_demaOkien.Data.BD2_2Db())
			{
				var exams = from exam in Db.Examination_dictionary
							select new
							{
								name = exam.Examination_name.ToString(),
								code = exam.Examination_code.ToString()
							};
				comboBox1.DataSource = exams.Select(a => a.code).ToList();
				examNames = exams.Select(b => b.name).ToList();
				examCodes = exams.Select(b => b.code).ToList();
			}
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
			switch (mode)
			{
				case ExaminationMode.LAB:
					Examination.InsertLABExamination(comboBox1.SelectedIndex.ToString(), richTextBox1.Text, visitId);
					break;
				case ExaminationMode.PHYSICAL:
					Examination.InsertPhysicalExamination(comboBox1.SelectedIndex.ToString(), richTextBox1.Text, visitId);
					break;
				default:
					break;
			}			
			Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			var temp = comboBox1.SelectedIndex.ToString();
			int index = examCodes.IndexOf(temp);
			textBox1.Text = examNames[index];
		}
	}
}
