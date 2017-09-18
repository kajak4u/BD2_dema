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
                    new KeyValuePair<string,string>("ZLE","Zlecone"),
                    new KeyValuePair<string,string>("WYK","Wykonane"),
                    new KeyValuePair<string,string>("AKC","Zaakceptowane"),
                    new KeyValuePair<string,string>("AN_L","Anulowane (lab)"),
                    new KeyValuePair<string,string>("AN_K","Anulowane (klab)")
                };
            }
        }
        static public List<string> statusList { get { return statusDictionary.Select(item => item.Value).ToList(); } }
        static public List<string> keyList { get { return statusDictionary.Select(item => item.Key).ToList(); } }
    }
    public static class UserRole
    {
        static public List<KeyValuePair<string, string>> roleDictionary
        {
            get
            {
                return new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string,string>("","Wszystkie"),
                    new KeyValuePair<string,string>("registrar", "Rejestrator"),
                    new KeyValuePair<string,string>("doctor","Lekarz"),
                    new KeyValuePair<string,string>("lab","Laborant"),
                    new KeyValuePair<string,string>("klab","Kierownik lab."),
                    new KeyValuePair<string,string>("admin","Administrator")
                };
            }
        }
        static public List<string> valueList { get { return roleDictionary.Select(item => item.Value).ToList(); } }
        static public List<string> keyList { get { return roleDictionary.Select(item => item.Key).ToList(); } }
    }
}