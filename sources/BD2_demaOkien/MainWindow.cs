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
        public static Role userRole { get; private set; }
        public static int userId { get; private set; }
        public static object LastSelectResult { get; set; }
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
                    //rejestratorkaToolStripMenuItem.Visible = true;
                    //lekarzToolStripMenuItem.Visible = true;
                    //laborantToolStripMenuItem.Visible = true;
                    //kierLabToolStripMenuItem.Visible = true;
                    //adminToolStripMenuItem.Visible = true;
                    BringMenuToFront(adminToolStripMenuItem);
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
            OpenMDIWindow(new VisitsWindow(null));
        }

        private void przeglądMoichWizytToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMDIWindow(new VisitsWindow_Doctor());
        }

        private void badaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMDIWindow(new ExaminationsWindow());
        }

        private void słownikBadańToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMDIWindow(new ExaminationsDictionariesWindow());
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMDIWindow(new AdminMainWindow());
        }

        static public void ShowError(String message, String caption="Błąd")
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        static public bool ShowQuestion(String message, String caption="Pytanie")
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
