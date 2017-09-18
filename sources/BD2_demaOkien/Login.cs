using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BD2_demaOkien.Data;
using BD2_demaOkien.BizzLayer;

namespace BD2_demaOkien
{
	public partial class Login : Form
	{
		public string userLogin { get; private set; }
		public Role userRole { get; private set; }
		private string userPassword { get; set; }
		public int userId { get; private set; }

		public Login()
		{
			InitializeComponent();
		}

		private bool? PerformLogin()
		{
            //zaszyfruj wszystko
            //using (BD2_2Db Db = new BD2_2Db())
            //{
            //    Db.Worker
            //        .Where(w => w.Password.Length < 20)
            //        .ToList()
            //        .ForEach(w => w.Password = Workers.Hash(w.Password));
            //    try
            //    {
            //        Db.SaveChanges();
            //    }
            //    catch (Exception e)
            //    {

            //    }
            //}

            userLogin = loginBox.Text;
			userPassword = passwordBox.Text;
            var worker = Workers.Get(userLogin, userPassword);

            if (worker != null)
            {
                try
                {
                    if (worker.Expiration_date != null && DateTime.Compare(worker.Expiration_date.Value, DateTime.Now) <= 0)
                    {
                        this.DialogResult = DialogResult.None;
                        MainWindow.ShowError("Konto wygasło!", "Błąd logowania");
                        return null;
                    }
                    userRole = (Role)Enum.Parse(typeof(Role), worker.Role.ToUpper());
                    userId = worker.Worker_id;
                    return true;
                }
                catch (Exception)
                {
                    this.DialogResult = DialogResult.None;
                    MainWindow.ShowError("Nieznana rola!", "Błąd logowania");
                    return null;
                }
            }
            else
                return false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
            bool? temp = PerformLogin();
            if (temp == false)
			{
				this.DialogResult = DialogResult.None;
                MainWindow.ShowError("Błedny login i/lub hasło!", "Błąd logowania");
			}
		}

        private void Login_Load(object sender, EventArgs e)
        {
            //auto-logowanie dla przyspieszenia testów
            //loginBox.Text = "admin";
            //passwordBox.Text = "admin";
            //button1.PerformClick();
        }
    }
}
