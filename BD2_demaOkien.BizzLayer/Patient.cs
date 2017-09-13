﻿using BD2_demaOkien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD2_demaOkien.BizzLayer
{
    public class Patients
    {
        public static Data.Patient getByPESEL(string PESEL)
        {
            using (var Db = new BD2_2Db())
            {
                var worker = Db.Patient
                    .Where(p => p.PESEL.Equals(PESEL))
                    .FirstOrDefault();
                return worker;
            }
        }
    }
}
