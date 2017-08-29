﻿using System;
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

    public class AllPatientsData {
        public int Patient_id;
        public string First_name;
        public string Last_name;
        public string PESEL;
        public string Phone_number;
        public string Address;
    }

    public class PatientData
    {
        public string First_name;
        public string Last_name;
        public string PESEL;
        public string address;
    }

    static public class Worker {
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

    static public class Visit {
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
                                 Address = address.Flat_number != null ? address.City + " " +address.Street + " " + address.House_number + " " + address.Flat_number : address.City + " " + address.Street + " " + address.House_number
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
                                  First_name = patients.First_name,
                                  Last_name = patients.Last_name,
                                  PESEL = patients.PESEL,
                                  address = address.Flat_number != null ? address.City + " " + address.Street + " " + address.House_number + " " + address.Flat_number : address.City + " " + address.Street + " " + address.House_number
                              };
                //var patients = Db.Patient.ToList();
                return patient.FirstOrDefault();
            }
        }

    }

    static public class Patient {

    }

    
}
