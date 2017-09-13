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
        string userLogin;
        Role userRole;
        public static int userId { get; private set; }
        public MainWindow()
        {
            this.Hide();
            Login login = new Login();
            if (login.ShowDialog() == DialogResult.OK)
            {
                InitializeComponent();
                userLogin = login.userLogin;
                userRole = login.userRole;
                userId = login.userId;
                SetVisibility(userRole);
            }
            else
                throw new Exception("Permission denied");
        }
        private void BringMenuToFront(ToolStripMenuItem menu)
        {
            var menuitems = new List<ToolStripMenuItem>();
            foreach (ToolStripMenuItem item in menu.DropDown.Items)
                menuitems.Add(item);
            menuitems.ForEach(item => item.Owner = item.OwnerItem.Owner);
        }
        private void SetVisibility(Role role)
        {
            switch (role)
            {
                case Role.REGISTRAR:
                    BringMenuToFront(rejestratorkaToolStripMenuItem);
                    break;
                case Role.DOCTOR:
                    BringMenuToFront(lekarzToolStripMenuItem);
                    break;
                case Role.LAB:
                    BringMenuToFront(laborantToolStripMenuItem);
                    break;
                case Role.KLAB:
                    BringMenuToFront(kierLabToolStripMenuItem);
                    break;
                case Role.ADMIN:
                    rejestratorkaToolStripMenuItem.Visible = true;
                    lekarzToolStripMenuItem.Visible = true;
                    laborantToolStripMenuItem.Visible = true;
                    kierLabToolStripMenuItem.Visible = true;
                    adminToolStripMenuItem.Visible = true;
                    break;
                default:
                    break;
            }
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
            OpenMDIWindow(new VisitsWindow(Role.REGISTRAR, null));
        }

        private void wynikibadańToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMDIWindow(new ExaminationsWindow(Role.REGISTRAR));
        }

        private void wizytyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenMDIWindow(new VisitsWindow(Role.DOCTOR, userId));
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
