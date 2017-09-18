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
                    OpenMDIWindow(new PatientsWindow());
                    break;
                case Role.DOCTOR:
                    BringMenuToFront(lekarzToolStripMenuItem);
                    OpenMDIWindow(new VisitsWindow_Doctor());
                    break;
                case Role.LAB:
                    BringMenuToFront(laborantToolStripMenuItem);
                    OpenMDIWindow(new ExaminationsWindow());
                    break;
                case Role.KLAB:
                    BringMenuToFront(kierLabToolStripMenuItem);
                    OpenMDIWindow(new ExaminationsWindow());
                    break;
                case Role.ADMIN:
                    BringMenuToFront(adminToolStripMenuItem);
                    OpenMDIWindow(new AdminMainWindow());
                    break;
                default:
                    break;
            }
        }
        private void OpenMDIWindow(Form window)
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

        private void MainWindow_Load(object sender, EventArgs e)
        {
            SetVisibility(userRole);
        }

        public void RegisterMDI(Form form, OnDuplicateAction onDuplicate)
        {
            string newClassName = form.GetType().Name;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Normal;
            form.ControlBox = false;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.Dock = DockStyle.Fill;
            form.Activated += (sender, e) =>
            {
                ((Form)sender).WindowState = FormWindowState.Normal;
                ((Form)sender).MdiParent.Text = "Program medyczny - [" + ((Form)sender).Text + "]";
            };
            this.ActivateMdiChild(null);
            this.ActivateMdiChild(form);
            this.Text = "Program medyczny - [" + form.Text + "]";

            foreach (Form openForm in MdiChildren)
            {
                if(openForm.GetType().Name.Equals(newClassName) && openForm!=form)
                {
                    switch(onDuplicate)
                    {
                        case OnDuplicateAction.CloseOther:
                            openForm.Close();
                            form.BringToFront();
                            break;
                        case OnDuplicateAction.CloseThis:
                            BeginInvoke((Action)(()=> {
                                form.Close();
                                openForm.BringToFront();
                            }));
                            return;
                    }
                }
            }
            form.BringToFront();
            form.Refresh();
        }
    }
}
