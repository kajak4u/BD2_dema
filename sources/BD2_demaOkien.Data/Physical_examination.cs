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
    
    public partial class Physical_examination
    {
        public int Physical_examination_id { get; set; }
        public string Physical_examination_code { get; set; }
        public string Result { get; set; }
        public int visit_id { get; set; }
    
        public virtual Examination_dictionary Examination_dictionary { get; set; }
        public virtual Visit Visit { get; set; }
    }
}
