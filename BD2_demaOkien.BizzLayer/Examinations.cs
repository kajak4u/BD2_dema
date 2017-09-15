using BD2_demaOkien.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BD2_demaOkien.BizzLayer
{
    public class Examinations
    {
        public static IEnumerable<LabExaminationData> GetAll()
        {
            using (BD2_2Db Db = new BD2_2Db())
            {
                //worker - lab
                //worker1 - klab
                return Db.LAB_examination
                    .Include(ex => ex.Examination_dictionary)
                    .Include(ex => ex.Worker1)
                    .Include(ex => ex.Visit)
                    .Include(ex => ex.Visit.Patient)
                    .Select(Le => new LabExaminationData
                    {
                        id = Le.LAB_examination_id,
                        type = Le.Examination_dictionary.Examiantion_type,
                        data_zlec = Le.commission_examination_date,
                        data_wyk = Le.LAB_examination_date,
                        status = Le.status,
                        lab = Le.Worker.First_name+" "+Le.Worker.Last_name,
                        patient = Le.Visit.Patient.First_name+" "+Le.Visit.Patient.Last_name
                    })
                    .ToList();
            }
        }
    }

    public class LabExaminationData
    {
        public DateTime? data_wyk { get; set; }
        public DateTime? data_zlec { get; set; }
        public int id { get; internal set; }
        public string lab { get; set; }
        public string patient { get; set; }
        public string status { get; set; }
        public string type { get; set; }
    }
}