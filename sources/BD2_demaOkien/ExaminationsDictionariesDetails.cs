using BD2_demaOkien.BizzLayer;
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
	public partial class ExaminationsDictionariesDetails : Form
	{
		private ViewMode mode_mode;
        private string examinationCode;

        public ExaminationsDictionariesDetails(ViewMode mode, string examinationCode, ExaminationMode? examinationType=null)
		{
            this.examinationCode = examinationCode;
			InitializeComponent();
			mode_mode = mode;
            if (mode == ViewMode.CREATE)
            {
                Text = "Dodaj badanie";
                textBox2.Enabled = true;
                if (examinationType.HasValue)
                {
                    switch (examinationType.Value)
                    {
                        case ExaminationMode.LAB:
                            radioButton2.Checked = true;
                            break;
                        case ExaminationMode.PHYSICAL:
                            radioButton1.Checked = true;
                            break;
                    }
                }
            }
            else if (mode == ViewMode.EDIT)
            {
                Examination_dictionary dict = BizzLayer.ExaminationsDictionary.Get(examinationCode);
                Text = "Edytuj badanie";
                textBox2.Text = dict.Examination_code;
                textBox1.Text = dict.Examination_name;
                switch (dict.Examiantion_type)
                {
                    case "L":
                        radioButton2.Checked = true;
                        break;
                    case "F":
                        radioButton1.Checked = true;
                        break;
                }
            }
            
		}

		private void buttonApply_Click(object sender, EventArgs e)
		{
			switch (mode_mode)
			{
				case ViewMode.CREATE:
                    string newCode = textBox2.Text;
                    if (ExaminationsDictionary.Get(newCode) != null)
                    {
                        MainWindow.ShowError("Badanie o podanym kodzie już istnieje!");
                        return;
                    }
                    ExaminationsDictionary.insertExaminationData(textBox1.Text, textBox2.Text, radioButton1.Checked ? "F" : "L");
					break;
				case ViewMode.EDIT:
					ExaminationsDictionary.editExaminationData(textBox1.Text, textBox2.Text, radioButton1.Checked ? "F" : "L");
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
	}
}
