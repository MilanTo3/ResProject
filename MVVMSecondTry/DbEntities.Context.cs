﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVVMSecondTry
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ResDbEntities : DbContext
    {
        public ResDbEntities()
            : base("name=ResDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<LkRe> LkRes { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<UnitGroup> UnitGroups { get; set; }
    }
}
