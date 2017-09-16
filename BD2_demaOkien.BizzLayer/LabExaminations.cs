using BD2_demaOkien.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BD2_demaOkien.BizzLayer
{
    public class LabExaminationData : Data.LAB_examination
    {
        public string Lab { get; set; }
        public string Nazwa { get; set; }
        public string Klab { get; set; }
        public string Pacjent { get; set; }
    }
    public class LabExaminations
    {
        public static IEnumerable<LabExaminationData> Get(ExaminationFilterParams filter)
        {
            using (var Db = new BD2_demaOkien.Data.BD2_2Db())
            {
                IQueryable<LAB_examination> result = Db.LAB_examination
                    .Include(ex => ex.Visit)
                    .Include(ex => ex.Worker)
                    .Include(ex => ex.Worker1)
                    .Include(ex => ex.Examination_dictionary);
                if (filter.patient_id.HasValue)
                    result = result.Where(ex => ex.Visit.patient_id == filter.patient_id.Value);
                if (filter.visit_id.HasValue)
                    result = result.Where(ex => ex.visit_id == filter.visit_id.Value);
                if (filter.data_wyk.HasValue)
                    result = result.Where(ex => filter.data_wyk.Value.Date == ex.LAB_examination_date.Value.Date);
                if (filter.data_zlec.HasValue)
                    result = result.Where(ex => filter.data_zlec.Value.Date == ex.commission_examination_date.Date);
                if (filter.doctorId.HasValue)
                    result = result.Where(ex => ex.Visit.doctor_id == filter.doctorId.Value);
                if (filter.labId.HasValue)
                    result = result.Where(ex => ex.LAB_worker_id == filter.labId.Value);
                if (filter.klabId.HasValue)
                    result = result.Where(ex => ex.LAB_manager_id == filter.klabId.Value);
                if (filter.patient_PESEL != null && filter.patient_PESEL != "")
                    result = result.Where(ex => ex.Visit.Patient.PESEL.Equals(filter.patient_PESEL));
                if (filter.status != null && filter.status != "")
                    result = result.Where(ex => ex.status.Equals(filter.status));
                return result.Select(ex => new LabExaminationData
                {
                    commission_examination_date = ex.commission_examination_date,
                    doctor_notes = ex.doctor_notes,
                    ending_examination_date = ex.ending_examination_date,
                    LAB_examination_code = ex.LAB_examination_code,
                    LAB_examination_date = ex.LAB_examination_date,
                    LAB_examination_id = ex.LAB_examination_id,
                    LAB_examination_result = ex.LAB_examination_result,
                    LAB_manager_id = ex.LAB_manager_id,
                    LAB_manager_notes = ex.LAB_manager_notes,
                    LAB_worker_id = ex.LAB_worker_id,
                    status = ex.status,
                    Visit = ex.Visit,
                    visit_id = ex.visit_id,
                    Nazwa = ex.Examination_dictionary.Examination_name,
                    Lab = ex.Worker.First_name + " " + ex.Worker.Last_name,
                    Klab = ex.Worker1.First_name + " " + ex.Worker1.Last_name,
                    Pacjent = ex.Visit.Patient.First_name+" "+ex.Visit.Patient.Last_name
                }).ToList();
            }
        }

        public static void Add(String code, String notes, int visitId)
        {
            LAB_examination exam = new LAB_examination
            {
                LAB_examination_code = code,
                doctor_notes = notes,
                visit_id = visitId,
                commission_examination_date = DateTime.Now,
                status = "COM"
            };
            using (var db = new BD2_2Db())
            {
                db.LAB_examination.Add(exam);
                db.SaveChanges();
            }
        }

        public static void DeleteFromVisit(int visitId)
        {
            using (var db = new BD2_2Db())
            {
                var labEx = db.LAB_examination.Where(ex => ex.visit_id == visitId).ToList();
                db.LAB_examination.RemoveRange(labEx);
                db.SaveChanges();
            }
        }
    }
}