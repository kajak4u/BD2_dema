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
    public partial class Login : Form
    {
        public string userLogin {get; private set;}
        public Role userRole { get; private set; }
        private string userPassword { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private bool PerformLogin()
        {
            userLogin = loginBox.Text;
            userPassword = passwordBox.Text;
            // tutaj łączenie z bazą i sprawdzanie poświadczeń
            // ... bla bla bla ...
            // jeżeli poprawne poświadczenia, to uzupelniamy rolę
            switch(userLogin.ToLower())
            {
                case "registrar":
                    userRole = Role.REGISTRAR;
                    break;
                case "doctor":
                    userRole = Role.DOCTOR;
                    break;
                case "lab":
                    userRole = Role.LAB;
                    break;
                case "klab":
                    userRole = Role.KLAB;
                    break;
                case "admin":
                    userRole = Role.ADMIN;
                    break;
                default:
                    return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!PerformLogin())
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show(this, "Invalid login and/or password!", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
