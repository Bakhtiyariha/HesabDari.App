﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HesabDari.DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HesabDariEntitiesnew : DbContext
    {
        public HesabDariEntitiesnew()
            : base("name=HesabDariEntitiesnew")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Accounting> Accounting { get; set; }
        public virtual DbSet<AccountingType> AccountingType { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
        public virtual DbSet<Login> Login { get; set; }
    }
}