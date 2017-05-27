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
            new ExaminationsDetailWindow().ShowDialog();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //new ExaminationsAddWindow().ShowDialog();
        }
    }
}
