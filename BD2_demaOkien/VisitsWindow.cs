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
    public partial class VisitsWindow : Form
    {
        public VisitsWindow(Role openedRole)
        {
            InitializeComponent();
            if(openedRole == Role.DOCTOR)
            {
                label4.Visible = false;
                comboBox2.Visible = false;
                comboBox2.SelectedValue = "/**current user**/";
                bindingNavigatorAddNewItem.Visible = false;
                this.comboBox1.SelectedText = "Zarejestrowane";
            }
            else if(openedRole == Role.REGISTRAR)
            {
                textBox3.Enabled = false;
                textBox3.Text = "/**current patient**/";
                this.Text = "Wizyty dla: ";
            }
        }

        private void VisitsWindow_Load(object sender, EventArgs e)
        {
        }

        private void bindingNavigatorItemData_Click(object sender, EventArgs e)
        {
            new VisitDetailsWindow_Register(ViewMode.VIEW).ShowDialog();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new VisitDetailsWindow_Register(ViewMode.CREATE).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.visitTableAdapter.Fill(this.bD_2DataSet.Visit);
            //TODO: filtry
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

            bool currentExists = (bindingNavigator1.BindingSource != null && bindingNavigator1.BindingSource.Current != null);

            bindingNavigatorEditItem.Enabled = currentExists;
            bindingNavigatorItemData.Enabled = currentExists;
            bindingNavigatorItemCancel.Enabled = currentExists;
        }
    }
}
