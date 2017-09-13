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
				bindingNavigatorAddNewItem.Visible = false;
			}
		}

		private void bindingNavigatorItemData_Click(object sender, EventArgs e)
		{
			ParametersForExamDetails para = new ParametersForExamDetails();
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

			new ExaminationsDetailWindow(para, /*isLab*/true).ShowDialog();
		}

		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			//new ExaminationsAddWindow().ShowDialog();
		}
	}
}
