//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BD2_demaOkien.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Worker
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Worker()
        {
            this.RegisteredVisits = new HashSet<Visit>();
            this.PerformedVisits = new HashSet<Visit>();
            this.LAB_examination = new HashSet<LAB_examination>();
            this.LAB_examination1 = new HashSet<LAB_examination>();
        }
    
        public int Worker_id { get; set; }
        public string Role { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public Nullable<int> NPWZ { get; set; }
        public string E_mail_Address { get; set; }
        public string Phone_number { get; set; }
        public string PESEL { get; set; }
        public int address_id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> Expiration_date { get; set; }
    
        public virtual Address Address { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visit> RegisteredVisits { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visit> PerformedVisits { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LAB_examination> LAB_examination { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LAB_examination> LAB_examination1 { get; set; }
    }
}
