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
    
    public partial class LAB_examination
    {
        public int LAB_examination_id { get; set; }
        public string LAB_examination_code { get; set; }
        public string doctor_notes { get; set; }
        public Nullable<int> LAB_worker_id { get; set; }
        public System.DateTime commission_examination_date { get; set; }
        public string LAB_examination_result { get; set; }
        public Nullable<System.DateTime> LAB_examination_date { get; set; }
        public Nullable<int> LAB_manager_id { get; set; }
        public string LAB_manager_notes { get; set; }
        public Nullable<System.DateTime> ending_examination_date { get; set; }
        public string status { get; set; }
        public int visit_id { get; set; }
    
        public virtual Examination_dictionary Examination_dictionary { get; set; }
        public virtual Visit Visit { get; set; }
        public virtual Worker Worker { get; set; }
        public virtual Worker Worker1 { get; set; }
    }
}
