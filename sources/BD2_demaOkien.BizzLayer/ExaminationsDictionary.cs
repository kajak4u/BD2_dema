using BD2_demaOkien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD2_demaOkien.BizzLayer
{
    static public class ExaminationsDictionary
    {
        public static List<Examination_dictionary> Get(ExaminationMode? mode)
        {
            using (BD2_2Db Db = new BD2_2Db())
            {
                if (mode.HasValue)
                {
                    string modeStr = (mode == ExaminationMode.LAB ? "L" : "F");
                    return Db.Examination_dictionary
                        .Where(dict => dict.Examiantion_type.Equals(modeStr))
                        .ToList();
                }
                else
                    return Db.Examination_dictionary.ToList();
            }
        }
        public static Examination_dictionary Get(string code)
        {
            using (BD2_2Db Db = new BD2_2Db())
            {
                return Db.Examination_dictionary
                    .Where(dict => dict.Examination_code == code)
                    .FirstOrDefault();
            }
        }

        public static void insertExaminationData(String name, String code, String type)
        {
            Examination_dictionary exam = new Examination_dictionary { Examiantion_type = type, Examination_code = code, Examination_name = name };
            using (var db = new BD2_2Db())
            {
                var matchExam = db.Examination_dictionary
                    .Where(ex =>
                    (ex.Examination_code == null ? exam.Examination_code == null : ex.Examination_code.Equals(exam.Examination_code))
                    && (ex.Examination_name == null ? exam.Examination_name == null : ex.Examination_name.Equals(exam.Examination_name))
                    && (ex.Examiantion_type == null ? exam.Examiantion_type == null : ex.Examiantion_type.Equals(exam.Examiantion_type)))
                    .Count();
                if (matchExam == 0)
                {
                    db.Examination_dictionary.Add(exam);
                    try
                    {
                        db.SaveChanges();
                    }
                    catch(System.Data.Entity.Validation.DbEntityValidationException ex)
                    {
                        throw new EntityValidationErrorWrapper(ex);
                    }
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
}
