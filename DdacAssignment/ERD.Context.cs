﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DdacAssignment
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ERDContainer : DbContext
    {
        public ERDContainer()
            : base("name=ERDContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Shipment> Shipments { get; set; }
        public virtual DbSet<Ship> Ships { get; set; }
        public virtual DbSet<Yard> Yards { get; set; }
        public virtual DbSet<Fleet> Fleets { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
    }
}
