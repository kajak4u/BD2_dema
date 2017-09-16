using BD2_demaOkien.Data;
using System;
using System.Collections.Generic;
using System.Linq;

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
    }
}