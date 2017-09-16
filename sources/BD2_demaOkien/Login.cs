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
//using BD2_demaOkien.BizzLayer;

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
			userLogin = loginBox.Text;
			userPassword = passwordBox.Text;

			// tutaj łączenie z bazą i sprawdzanie poświadczeń
			// ... bla bla bla ...
			// jeżeli poprawne poświadczenia, to uzupelniamy rolę

			using (var Db = new BD2_2Db())
			{
				var worker = Worker.getWorker(userLogin, userPassword);
				/*var worker = Db.Worker.ToList()
                    .Where(w => w.Login == userLogin && w.Password == userPassword)
                    .FirstOrDefault();*/

				//var userAdress = from workerTmp in Db.Worker
				//                 join adress in Db.Address
				//                 on workerTmp.address_id equals adress.Address_id
				//                 where workerTmp.Worker_id == 1
				//                 select new
				//                 {
				//                     workerTmp.First_name,
				//                     workerTmp.Last_name,
				//                     adress.City,
				//                     adress.Street
				//                 };

				//var user = userAdress.FirstOrDefault()?.Last_name;//Zabezpiecznie przed null pointer exception

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
	}
}
