﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jamcheck
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class jampracticeEntities : DbContext
    {
        public jampracticeEntities()
            : base("name=jampracticeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dealership> Dealerships { get; set; }
        public virtual DbSet<Fuel> Fuels { get; set; }
        public virtual DbSet<ImportFrom> ImportFroms { get; set; }
        public virtual DbSet<Make> Makes { get; set; }
        public virtual DbSet<Org> Orgs { get; set; }
        public virtual DbSet<parish> parishes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SteeringPosition> SteeringPositions { get; set; }
        public virtual DbSet<TransmissionType> TransmissionTypes { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<VehicleType> VehicleTypes { get; set; }
        public virtual DbSet<UserInfo> UserInfoes { get; set; }
        public virtual DbSet<ViewDealership> ViewDealerships { get; set; }
    }
}
