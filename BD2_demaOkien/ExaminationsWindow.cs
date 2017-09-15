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
	public partial class ExaminationsWindow : Form
	{
		private Role userType;

		public ExaminationsWindow()
		{
			InitializeComponent();
		}

		public ExaminationsWindow(Role userType)
		{
			InitializeComponent();
			this.userType = userType;
			SetBinderControls();
		}

		private void SetBinderControls()
		{
			if (userType == Role.REGISTRAR)
			{
				//bindingNavigatorAddNewItem.Visible = false;
			}
            bindingSource1.DataSource = BizzLayer.Examinations.GetAll().ToList();
		}

		private void bindingNavigatorItemData_Click(object sender, EventArgs e)
		{
			/*para.visitId = ;//znaleźć i przypisać

			String stat = ;//znaleźć i przypisać
			bool isLab = stat == "L";

			if (isLab)
			{
				para.labExamId = ;//znaleźć i przypisać
			}
			else
			{
				para.phyExamId = ;//znaleźć i przypisać
			}*/
            int labExamId = (int)dataGridView1.CurrentRow.Cells["Column7"].Value;

            new ExaminationsDetailWindow(labExamId).ShowDialog();
		}

		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			//new ExaminationsAddWindow(ExaminationMode.).ShowDialog();
		}
	}
}
