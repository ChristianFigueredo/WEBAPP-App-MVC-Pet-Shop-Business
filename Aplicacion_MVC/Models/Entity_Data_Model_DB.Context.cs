﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aplicacion_MVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Pet_Shop_BusinessEntities : DbContext
    {
        public Pet_Shop_BusinessEntities()
            : base("name=Pet_Shop_BusinessEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Document_Types> Document_Types { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Pet> Pets { get; set; }
        public virtual DbSet<Race> Races { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TodoItem> TodoItems { get; set; }
        public virtual DbSet<Type_Animals> Type_Animals { get; set; }
    }
}