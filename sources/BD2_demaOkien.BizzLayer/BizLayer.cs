using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD2_demaOkien.Data;
using System.Security.Cryptography;
using System.Data.Entity.Validation;
using System.Text.RegularExpressions;

namespace BD2_demaOkien
{

    public class EntityValidationErrorWrapper : Exception
    {
        public class EntityError
        {
            public string className { get;}
            public string propertyName { get; }
            public string errorMessage { get; }
            public EntityError(string className, string propertyName, string errorMessage)
            {
                this.className = className;
                this.propertyName = propertyName;
                this.errorMessage = errorMessage;
            }
        };
        public List<EntityError> errors { get; private set; }
        public string FullMessage { get; private set; }
        public EntityValidationErrorWrapper(DbEntityValidationException e)
            : base(e.Message, e)
        {
            FullMessage = "";
            errors = new List<EntityError>();
            foreach(var validateError in e.EntityValidationErrors)
            {
                string className = validateError.Entry.Entity.GetType().ToString();
                foreach (var error in validateError.ValidationErrors)
                {
                    errors.Add(new EntityError(className, error.PropertyName, error.ErrorMessage));
                    if (FullMessage != "")
                        FullMessage += Environment.NewLine;
                    FullMessage += Format(error.ErrorMessage);
                }
            }
        }
        private string Format(string originalMessage)
        {
            originalMessage = Regex.Replace(originalMessage, "musi być ciągiem lub typem tablicy o maksymalnej długości (\\d+)", "nie może być dłuższe niż $1 znaków");
            return originalMessage;
        }

        public void FormatForField(string v1, string v2)
        {
            FullMessage = FullMessage.Replace(v1, "'" + v2 + "'");
        }
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
}
