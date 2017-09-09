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


        public static void setPatientData(String name, String surname, String pesel, String phone, String city, String street, int houseNo, int? flatNo, int? id)
        {
            Address address = new Address();
            address.City = city;
            address.Street = street;
            address.House_number = houseNo;
            address.Flat_number = flatNo;

            Patient patient = new Patient();
            patient.First_name = name;
            patient.Last_name = surname;
            patient.PESEL = pesel;
            patient.Phone_number = phone;

            using (var Db = new BD2_2Db())
            {/*
                var addressResult = from add in Db.Address
                                    where add.City.Equals(city) && add.Street.Equals(street) && add.House_number.Equals(houseNo) && add.Flat_number.Equals(flatNo)
                                    select new List<int?>
                                    {
                                        add.Address_id
                                    };*/
                // if (addressResult.Count() == 0)
                // if (!Db.Address.Contains(address))
                int count = Db.Address.Count(addres => addres.City.Equals(city) && addres.Street.Equals(street) && addres.House_number.Equals(houseNo) && addres.Flat_number.Equals(flatNo));
                if (count == 0)
                //var a = Db.Address.Where(addres => addres.City.Equals(city) && addres.Street.Equals(street) && addres.House_number.Equals(houseNo) && addres.Flat_number.Equals(flatNo)).FirstOrDefault();
                //if (a == null)
                    Db.Address.Add(address);
                //var address_id= Db.Address
                //   .Where(ad => ad.City == city && ad.Street == street && ad.House_number == houseNo && ad.Flat_number == flatNo)
                //    .Select(ad => new
                //    {
                //       ad.Address_id
                //  });

                //Db.Address.
                var address_id = from addres in Db.Address
                                 where addres.City.Equals(city) && addres.Street.Equals(street) && addres.House_number.Equals(houseNo) && addres.Flat_number.Equals(flatNo)
                                 select new
                                 {
                                     Adress = addres.Address_id
                                 };
                patient.address_id = (int)address_id.FirstOrDefault().Adress;
                Db.Patient.Add(patient);
                Db.SaveChanges();

            }

        }

        public static void editPatientData(String name, String surname, String pesel, String phone, String city, String street, int houseNo, int flatNo, int id)
        {
            using (var Db = new BD2_2Db())
            {
                /*var patient = from patients in Db.Patient
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
                              };*/
                //var patients = Db.Patient.ToList();
                //return patient.FirstOrDefault();
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

    static public class Patients
    {

    }


}
