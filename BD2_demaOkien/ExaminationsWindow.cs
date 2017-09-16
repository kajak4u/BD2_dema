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
		private Role userRole;

		public ExaminationsWindow()
		{
			InitializeComponent();
			this.userRole = MainWindow.userRole;
			SetBinderControls();
		}

		private void SetBinderControls()
		{
			if (userRole == Role.REGISTRAR)
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

        private void ExaminationsWindow_Load(object sender, EventArgs e)
        {
            switch(userRole)
            {
                case Role.DOCTOR:
                    break;
                case Role.LAB:
                    break;
                case Role.KLAB:
                    break;
                case Role.REGISTRAR:
                    break;
            }
        }
    }
}
