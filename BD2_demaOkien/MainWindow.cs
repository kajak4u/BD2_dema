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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            InitializeComponent();
        }

        private void pacjenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patients patients = new Patients();
            patients.MdiParent = this;
            patients.Show();
        }
    }
}
