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
        public VisitsWindow()
        {
            InitializeComponent();
        }

        private void VisitsWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_2DataSet.Visit' table. You can move, or remove it, as needed.
            this.visitTableAdapter.Fill(this.bD_2DataSet.Visit);
            comboBox1.SelectedIndex = 0;
        }
    }
}
