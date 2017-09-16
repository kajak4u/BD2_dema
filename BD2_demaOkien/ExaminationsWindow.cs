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
            bindingSource1.DataSource = BizzLayer.LabExaminations.Get(new ExaminationFilterParams()).ToList();
		}

		private void bindingNavigatorItemData_Click(object sender, EventArgs e)
		{
            int labExamId = (int)dataGridView1.CurrentRow.Cells["Column7"].Value;

            new ExaminationsDetailWindow(labExamId).ShowDialog();
		}

		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			//new ExaminationsAddWindow(ExaminationMode.).ShowDialog();
		}
	}
}
