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
	}

	static public class Visit
	{
		//takes all patients from db
		public static List<AllPatientsData> getAllPatients()
		{
			using (var Db = new BD2_2Db())
			{
				var patients = from patient in Db.Patient
							   join address in Db.Address
							   on patient.address_id equals address.Address_id
							   select new AllPatientsData
							   {
								   Patient_id = patient.Patient_id,
								   First_name = patient.First_name,
								   Last_name = patient.Last_name,
								   PESEL = patient.PESEL,
								   Phone_number = patient.Phone_number,
								   Address = address.Flat_number != null ? address.City + " " + address.Street + " " + address.House_number + " " + address.Flat_number : address.City + " " + address.Street + " " + address.House_number
							   };
				//var patients = Db.Patient.ToList();
				return patients.ToList();
			}
		}

		//gets one patient from database by all data 
		public static List<AllPatientsData> getPatientByAllData(String FirstName, String LastName, String Pesel)
		{
			using (var Db = new BD2_2Db())
			{
				var patient = from patients in Db.Patient
							  join address in Db.Address
							  on patients.address_id equals address.Address_id
							  where patients.First_name.Contains(FirstName) && patients.Last_name.Contains(LastName) && patients.PESEL.Contains(Pesel)//FirstName == patients.First_name && LastName == patients.Last_name //&& Pesel == patients.PESEL
							  select new AllPatientsData
							  {
								  Patient_id = patients.Patient_id,
								  First_name = patients.First_name,
								  Last_name = patients.Last_name,
								  PESEL = patients.PESEL,
								  Address = address.Flat_number != null ? address.City + " " + address.Street + " " + address.House_number + " " + address.Flat_number : address.City + " " + address.Street + " " + address.House_number
							  };
				//var patients = Db.Patient.ToList();
				return patient.ToList();
			}
		}

		public static PatientData getPatientById(int id)
		{
			using (var Db = new BD2_2Db())
			{
				var patient = from patients in Db.Patient
							  join address in Db.Address
							  on patients.address_id equals address.Address_id
							  where patients.Patient_id == id
							  select new PatientData
							  {
								  Patient_id = patients.Patient_id,
								  First_name = patients.First_name,
								  Last_name = patients.Last_name,
								  PESEL = patients.PESEL,
								  Phone_number = patients.Phone_number,
								  City = address.City,
								  Street = address.Street,
								  HouseNo = address.House_number,
								  FlatNo = address.Flat_number
								  //address = address.Flat_number != null ? address.City + " " + address.Street + " " + address.House_number + " " + address.Flat_number : address.City + " " + address.Street + " " + address.House_number
							  };
				//var patients = Db.Patient.ToList();
				return patient.FirstOrDefault();
			}
		}

		public static void deleteUser(int id)
		{
			using (var Db = new BD2_2Db())
			{
				var patient = Db.Patient.Where(p => p.Patient_id == id).FirstOrDefault();
				if (patient == null)
					throw new Exception("No such patient!");

				//Db.Address.Remove(add.First()); - adres zostaje w bazie! - co jeśli ktoś inny też go ma?
				Db.Patient.Remove(patient);
				Db.SaveChanges();
			}

		}


		public static void setPatientData(String name, String surname, String pesel, String phone, String city, String street, int houseNo, int? flatNo, int? id)
		{
			Address address = new Address { City = city, Street = street, House_number = houseNo, Flat_number = flatNo };

			Patient patient = new Patient { First_name = name, Last_name = surname, PESEL = pesel, Phone_number = phone };

			using (var Db = new BD2_2Db())
			{
				var matchAddresses = Db.Address
					.Where(add =>
						 (add.City == null ? address.City == null : add.City.Equals(address.City))
							&& (add.Street == null ? address.Street == null : add.Street.Equals(address.Street))
							&& add.House_number == address.House_number
							&& (!add.Flat_number.HasValue ? !address.Flat_number.HasValue : add.Flat_number.Value == address.Flat_number.Value));
				if (matchAddresses.Count() == 0)
				{
					Db.Address.Add(address);
					//Db.SaveChanges(); // ważne!
				}
				else
					address = matchAddresses.First();

				patient.Address = address;
				Db.Patient.Add(patient);
				Db.SaveChanges();
			}
		}

		public static void editPatientData(String name, String surname, String pesel, String phone, String city, String street, int houseNo, int? flatNo, int id)
		{
			using (var Db = new BD2_2Db())
			{
				var patientData = Db.Patient.Where(p => p.Patient_id == id).FirstOrDefault();
				patientData.First_name = name;
				patientData.Last_name = surname;
				patientData.PESEL = pesel;
				patientData.Phone_number = phone;

				var patientAddress = Db.Address.Where(p => p.Address_id == patientData.address_id).FirstOrDefault();
				patientAddress.City = city;
				patientAddress.Street = street;
				patientAddress.House_number = houseNo;
				patientAddress.Flat_number = flatNo;
				Db.SaveChanges();
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
