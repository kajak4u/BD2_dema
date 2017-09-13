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
		private List<String> codes;
		private List<String> names;
		private List<String> types;
		private ViewMode mode_mode;

		public ExaminationsDictionariesDetails(ViewMode mode)
		{
			InitializeComponent();
			mode_mode = mode;
			if (mode == ViewMode.CREATE)
				Text = "Dodaj badanie";
			else if (mode == ViewMode.EDIT)
				Text = "Edytuj badanie";

			using (var Db = new BD2_demaOkien.Data.BD2_2Db())
			{
				var dict = from exam in Db.Examination_dictionary
						   select new
						   {
							   name = exam.Examination_name,
							   code = exam.Examination_code,
							   type = exam.Examiantion_type
						   };
				codes = dict.Select(a => a.code).ToList();
				names = dict.Select(b => b.name).ToList();
				types = dict.Select(b => b.type).ToList();
			}
			textBox2.AutoCompleteMode = AutoCompleteMode.Append;
			textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
			AutoCompleteStringCollection col_code = new AutoCompleteStringCollection();
			textBox1.AutoCompleteMode = AutoCompleteMode.Append;
			textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
			AutoCompleteStringCollection col_name = new AutoCompleteStringCollection();
			foreach (string c in codes)
			{
				col_code.Add(c);
			}
			foreach(string c in names)
			{
				col_name.Add(c);
			}
			textBox2.AutoCompleteCustomSource = col_code;
			textBox1.AutoCompleteCustomSource = col_name;
		}

		private void buttonApply_Click(object sender, EventArgs e)
		{
			switch (mode_mode)
			{
				case ViewMode.CREATE:
					BD2_demaOkien.ExaminationDictionary.insertExaminationData(textBox1.Text, textBox2.Text, radioButton1.Checked ? "F" : "L");
					break;
				case ViewMode.EDIT:
					BD2_demaOkien.ExaminationDictionary.editExaminationData(textBox1.Text, textBox2.Text, radioButton1.Checked ? "F" : "L");
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
