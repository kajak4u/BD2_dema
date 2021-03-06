﻿using BD2_demaOkien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BD2_demaOkien.BizzLayer
{
    public class Workers
    {
        public static IEnumerable<Data.Worker> GetAll(Role role)
        {
            string strRole = role.ToString().ToUpper();
            using (var Db = new BD2_2Db())
            {
                return Db.Worker
                    .Where(w => w.Role.Equals(strRole))
                    .ToList();
            }
        }
        public static Data.Worker Get(String userLogin, String userPassword)
        {
            String hashPasswd = Hash(userPassword);
            using (var Db = new BD2_2Db())
            {
                var worker = Db.Worker
                    .Where(w => w.Login.Equals(userLogin) && w.Password.Equals(hashPasswd))
                    .FirstOrDefault();
                return worker;
            }
        }
        public static string Hash(string stringToHash)
        {
            using (var sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(stringToHash));
                var sb = new StringBuilder(hash.Length * 2);
                foreach (byte b in hash)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        public static WorkerData getByID(int id)
        {
            using (var Db = new BD2_2Db())
            {
                var worker = Db.Worker
                    .Where(w => w.Worker_id==id)
                    .Select(w => new WorkerData
                    {
                        Worker_id = w.Worker_id,
                        First_name = w.First_name,
                        Last_name = w.Last_name,
                        PESEL = w.PESEL,
                        Phone_number = w.Phone_number,
                        City = w.Address.City,
                        Street = w.Address.Street,
                        HouseNo = w.Address.House_number,
                        FlatNo = w.Address.Flat_number,
                        role = w.Role.ToString(),
                        login = w.Login,
                        NPWZ = w.NPWZ,
                        ExpirationDate = w.Expiration_date,
                        email = w.E_mail_Address
                    });
                //var patients = Db.Patient.ToList();
                return worker.FirstOrDefault();
            }
        }
        private static Address ExtractAddress(WorkerData wd)
        {
            return new Address
            {
                City = wd.City,
                Street = wd.Street,
                House_number = wd.HouseNo,
                Flat_number = wd.FlatNo
            };
        }

        public static IEnumerable<Data.Worker> Get(UserFilterParams filter)
        {
            using (var Db = new BD2_2Db())
            {
                IQueryable<Data.Worker> res = Db.Worker;
                if (filter.First_Name != null && filter.First_Name != "")
                    res = res.Where(w => w.First_name.StartsWith(filter.First_Name));
                if (filter.Last_Name != null && filter.Last_Name != "")
                    res = res.Where(w => w.Last_name.StartsWith(filter.Last_Name));
                if (filter.Role != null && filter.Role != "")
                    res = res.Where(w => w.Role.Equals(filter.Role));
                return res.ToList();
            }
        }

        private static Data.Worker ExtractWorker(WorkerData wd)
        {
            return new Data.Worker
            {
                Worker_id = wd.Worker_id.HasValue ? wd.Worker_id.Value : 0,
                First_name = wd.First_name,
                Last_name = wd.Last_name,
                PESEL = wd.PESEL,
                Phone_number = wd.Phone_number,
                E_mail_Address = wd.email,
                Role = wd.role,
                Login = wd.login,
                Password = wd.Password,
                Expiration_date = wd.ExpirationDate,
                NPWZ = wd.NPWZ
            };
        }
        public static void Create(WorkerData wd)
        {
            Address address = ExtractAddress(wd);
            Data.Worker worker = ExtractWorker(wd);

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
                }
                else
                    address = matchAddresses.First();

                worker.Address = address;
                worker.Password = Hash(worker.Password);
                Db.Worker.Add(worker);
                try
                {
                    Db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    throw new EntityValidationErrorWrapper(ex);
                }
            }
        }
        public static void Update(WorkerData wd)
        {
            Address address = ExtractAddress(wd);
            Data.Worker worker2 = ExtractWorker(wd);

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
                }
                else
                    address = matchAddresses.First();
                var worker = Db.Worker.Where(w => w.Worker_id == worker2.Worker_id).FirstOrDefault();
                worker.First_name = worker2.First_name;
                worker.Last_name = worker2.Last_name;
                worker.PESEL = worker2.PESEL;
                worker.Phone_number = worker2.Phone_number;
                worker.E_mail_Address = worker2.E_mail_Address;
                worker.Role = worker2.Role;
                worker.Login = worker2.Login;
                if(worker2.Password!=null)
                    worker.Password = Hash(worker2.Password);
                worker.Expiration_date = worker2.Expiration_date;
                worker.NPWZ = worker2.NPWZ;
                worker.Address = address;
                try
                {
                    Db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    throw new EntityValidationErrorWrapper(ex);
                }
            }
        }
    }

    public class WorkerData
    {
        public string City { get; set; }
        public string email { get; set; }
        public string First_name { get; set; }
        public int? FlatNo { get; set; }
        public int HouseNo { get; set; }
        public string Last_name { get; set; }
        public string login { get; set; }
        public int? Worker_id { get; set; }
        public string PESEL { get; set; }
        public string Phone_number { get; set; }
        public string role { get; set; }
        public string Street { get; set; }
        public string Password { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int? NPWZ { get; set; }
    }


    public class UserFilterParams
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Role { get; set; }
    }
}