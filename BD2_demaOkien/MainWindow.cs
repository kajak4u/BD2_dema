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

        private void OpenMDIWindow<_T>(_T window) where _T: Form
        {
            window.MdiParent = this;
            window.Show();
        }

        private void pacjenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMDIWindow(new PatientsWindow());
        }

        private void wizytyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMDIWindow(new VisitsWindow(Role.REGISTRAR));
        }

        private void wynikibadańToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMDIWindow(new ExaminationsWindow(Role.REGISTRAR));
        }

        private void wizytyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenMDIWindow(new VisitsWindow(Role.DOCTOR));
        }

        private void przeglądMoichWizytToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMDIWindow(new VisitsWindow_Doctor());
        }

        private void badaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMDIWindow(new ExaminationsWindow(Role.DOCTOR));
        }

        private void badaniaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenMDIWindow(new ExaminationsWindowLabguy());
        }

        private void badaniaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenMDIWindow(new ExaminationsWindowLabmaster());
        }

        private void słownikBadańToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMDIWindow(new ExaminationsDictionariesWindow());
        }
    }
}
