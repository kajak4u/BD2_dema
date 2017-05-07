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
            PatientsWindow patients = new PatientsWindow();
            patients.MdiParent = this;
            patients.Show();
        }

        private void wizytyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitsWindow visits = new VisitsWindow(Role.REGISTRAR);
            visits.MdiParent = this;
            visits.Show();
        }

        private void wynikibadańToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExaminationsWindow examinations = new ExaminationsWindow(Role.REGISTRAR);
            examinations.MdiParent = this;
            examinations.Show();
        }

        private void wizytyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VisitsWindow visits = new VisitsWindow(Role.DOCTOR);
            visits.MdiParent = this;
            visits.Show();
        }

        private void przeglądMoichWizytToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitsWindow_Doctor visits = new VisitsWindow_Doctor();
            visits.MdiParent = this;
            visits.Show();
        }

        private void badaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExaminationsWindow visits = new ExaminationsWindow(Role.DOCTOR);
            visits.MdiParent = this;
            visits.Show();
        }
    }
}
