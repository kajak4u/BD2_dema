﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BD2_2Db : DbContext
    {
        public BD2_2Db()
            : base("name=BD2_2Db")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Examination_dictionary> Examination_dictionary { get; set; }
        public virtual DbSet<LAB_examination> LAB_examination { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Physical_examination> Physical_examination { get; set; }
        public virtual DbSet<Visit> Visit { get; set; }
        public virtual DbSet<Worker> Worker { get; set; }
    }
}