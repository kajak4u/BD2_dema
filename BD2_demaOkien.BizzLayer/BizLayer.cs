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


	static public class ExaminationDictionary
	{
		public static void insertExaminationData(String name, String code, String type)
		{
			Examination_dictionary exam = new Examination_dictionary { Examiantion_type = type, Examination_code = code, Examination_name = name };
			using (var db = new BD2_2Db())
			{
				var matchExam = db.Examination_dictionary
					.Where(ex =>
					(ex.Examination_code == null ? exam.Examination_code == null : ex.Examination_code.Equals(exam.Examination_code)
					&& ex.Examination_name == null ? exam.Examination_name == null : ex.Examination_name.Equals(exam.Examination_name)
					&& ex.Examiantion_type == null ? exam.Examiantion_type == null : ex.Examiantion_type == exam.Examiantion_type));
				if (matchExam.Count() == 0)
				{
					db.Examination_dictionary.Add(exam);
					db.SaveChanges();
				}
			}
		}

		public static void editExaminationData(String name, String code, String type)
		{
			using (var Db = new BD2_2Db())
			{
				var examData = Db.Examination_dictionary.Where(e => e.Examination_code == code).FirstOrDefault();
				examData.Examiantion_type = type;
				examData.Examination_code = code;
				examData.Examination_name = name;
				Db.SaveChanges();
			}
		}
	}

	static public class Examination
	{
		public static void InsertPhysicalExamination(String code, String result, int visitId)
		{
			Physical_examination exam = new Physical_examination { Physical_examination_code = code, Result = result, visit_id = visitId };
			using (var db = new BD2_2Db())
			{
				db.Physical_examination.Add(exam);
				db.SaveChanges();
			}
		}

		public static void InsertLABExamination(String code, String notes, int visitId)
		{
			LAB_examination exam = new LAB_examination { LAB_examination_code = code, doctor_notes = notes, visit_id = visitId, commission_examination_date = DateTime.Now };
			using (var db = new BD2_2Db())
			{
				db.LAB_examination.Add(exam);
				db.SaveChanges();
			}
		}
	}
}
