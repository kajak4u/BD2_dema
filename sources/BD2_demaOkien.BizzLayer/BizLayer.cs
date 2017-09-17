using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD2_demaOkien.Data;

namespace BD2_demaOkien
{
	class BizLayer
	{
		public static void Main() { }
	}

	public class AllPatientsData
	{
		public int Patient_id;
		public string First_name;
		public string Last_name;
		public string PESEL;
		public string Phone_number;
		public string Address;
	}

	public class PatientData
	{
		public int Patient_id;
		public string First_name;
		public string Last_name;
		public string PESEL;
		public string Phone_number;
		public string Street;
		public string City;
		public int HouseNo;
		public int? FlatNo;
	}

	static public class Worker
	{
		public static Data.Worker getWorker(String userLogin, String userPassword)
		{
			using (var Db = new BD2_2Db())
			{
				var worker = Db.Worker.ToList()
					.Where(w => w.Login == userLogin && w.Password == userPassword)
					.FirstOrDefault();
				return worker;
			}
		}
        public static Data.Worker getByID(int ID)
        {
            using (var Db = new BD2_2Db())
            {
                return Db.Worker.Where(w => w.Worker_id == ID).FirstOrDefault();
            }
        }
	}
}
