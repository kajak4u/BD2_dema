using System.Collections.Generic;
using System.Linq;

namespace BD2_demaOkien
{
    public enum ViewMode
    {
        CREATE,
        EDIT,
        VIEW,
        VIEW_ONLY
    }
    public enum ExaminationMode
    {
        LAB,
        PHYSICAL
    }

    public enum Role
    {
        REGISTRAR,
        DOCTOR,
        LAB,
        KLAB,
        ADMIN
    }
    public static class VisitStatus
    {
        static public List<KeyValuePair<string, string>> statusDictionary
        {
            get
            {
                return new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string,string>("", "Wszystkie"),
                    new KeyValuePair<string,string>("REJ","Zarejestrowane"),
                    new KeyValuePair<string,string>("ZAK","Odbyte"),
                    new KeyValuePair<string,string>("ANUL","Anulowane")
                };
            }
        }
        static public List<string> statusList { get { return statusDictionary.Select(item => item.Value).ToList(); } }
        static public List<string> keyList { get { return statusDictionary.Select(item => item.Key).ToList(); } }
    }
    public static class LabExaminationStatus
    {
        static public List<KeyValuePair<string, string>> statusDictionary
        {
            get
            {
                return new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string,string>("", "Wszystkie"),
                    new KeyValuePair<string,string>("COM","Zlecone"),
                    new KeyValuePair<string,string>("PER","Wykonane"),
                    new KeyValuePair<string,string>("APP","Zaakceptowane"),
                    new KeyValuePair<string,string>("ANUL","Anulowane (lab)"),
                    new KeyValuePair<string,string>("ANUM","Anulowane (klab)")
                };
            }
        }
        static public List<string> statusList { get { return statusDictionary.Select(item => item.Value).ToList(); } }
        static public List<string> keyList { get { return statusDictionary.Select(item => item.Key).ToList(); } }
    }
}