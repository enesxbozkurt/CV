﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcMyCv.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_cvEntities : DbContext
    {
        public db_cvEntities()
            : base("name=db_cvEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_deneyim> tbl_deneyim { get; set; }
        public virtual DbSet<tbl_egitim> tbl_egitim { get; set; }
        public virtual DbSet<tbl_giris> tbl_giris { get; set; }
        public virtual DbSet<tbl_hakkimda> tbl_hakkimda { get; set; }
        public virtual DbSet<tbl_hobi> tbl_hobi { get; set; }
        public virtual DbSet<tbl_iletisim> tbl_iletisim { get; set; }
        public virtual DbSet<tbl_sertifika> tbl_sertifika { get; set; }
        public virtual DbSet<tbl_yetenek> tbl_yetenek { get; set; }
        public virtual DbSet<tbl_sosyal_medya> tbl_sosyal_medya { get; set; }
    }
}
