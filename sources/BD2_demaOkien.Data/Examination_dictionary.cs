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
    
    public partial class Examination_dictionary
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Examination_dictionary()
        {
            this.LAB_examination = new HashSet<LAB_examination>();
            this.Physical_examination = new HashSet<Physical_examination>();
        }
    
        public string Examination_code { get; set; }
        public string Examiantion_type { get; set; }
        public string Examination_name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LAB_examination> LAB_examination { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Physical_examination> Physical_examination { get; set; }
    }
}
