using BD2_demaOkien.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BD2_demaOkien.BizzLayer
{
    public class ExaminationFilterParams
    {
        public DateTime? data_wyk { get; set; }
        public DateTime? data_zlec { get; set; }
        public int? doctorId { get; set; }
        public int? klabId { get; set; }
        public int? labId { get; set; }
        public int? patient_id { get; set; }
        public string patient_PESEL { get; set; }
        public string status { get; set; }
        public int? visit_id { get; set; }
    }

    public class PhysicalExaminationData
    {
        public int visit_id { get; set; }
        public string Nazwa { get; set; }
        public string Physical_examination_code { get; set; }
        public int Physical_Examination_Id { get; set; }
        public string Result { get; set; }
    }

    public class PhysicalExaminations
    {
        public static IEnumerable<PhysicalExaminationData> Get(ExaminationFilterParams filter)
        {
            using (var Db = new BD2_demaOkien.Data.BD2_2Db())
            {
                IQueryable<Physical_examination> result = Db.Physical_examination
                    .Include(ex => ex.Visit)
                    .Include(ex => ex.Examination_dictionary);
                if (filter.patient_id.HasValue)
                    result = result.Where(ex => ex.Visit.patient_id == filter.patient_id.Value);
                if (filter.visit_id.HasValue)
                    result = result.Where(ex => ex.visit_id == filter.visit_id.Value);
                if (filter.data_wyk.HasValue)
                    result = result.Where(ex => filter.data_wyk.Value.Date == ex.Visit.ending_date.Value.Date);
                if (filter.doctorId.HasValue)
                    result = result.Where(ex => ex.Visit.doctor_id == filter.doctorId.Value);
                if (filter.patient_PESEL != null && filter.patient_PESEL != "")
                    result = result.Where(ex => ex.Visit.Patient.PESEL.Equals(filter.patient_PESEL));
                return result.Select(ex => new PhysicalExaminationData
                {
                    visit_id = ex.visit_id,
                    Physical_Examination_Id = ex.Physical_examination_id,
                    Physical_examination_code = ex.Physical_examination_code,
                    Result = ex.Result,
                    Nazwa = ex.Examination_dictionary.Examination_name
                }).ToList();
            }
        }
        public static void Add(String code, String result, int visitId)
        {
            Physical_examination exam = new Physical_examination { Physical_examination_code = code, Result = result, visit_id = visitId };
            using (var db = new BD2_2Db())
            {
                db.Physical_examination.Add(exam);
                try
                {
                    db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    throw new EntityValidationErrorWrapper(ex);
                }
            }
        }

        public static void DeleteFromVisit(int visitId)
        {
            using (var db = new BD2_2Db())
            {
                var phEx = db.Physical_examination.Where(ex => ex.visit_id == visitId).ToList();
                db.Physical_examination.RemoveRange(phEx);
                try
                {
                    db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    throw new EntityValidationErrorWrapper(ex);
                }
            }
        }
    }

}