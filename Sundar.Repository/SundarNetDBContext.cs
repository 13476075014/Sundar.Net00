﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using Sundar.Repository.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
//using SundarNetDBContext;
//using SundarNetDBContext;

namespace Sundar.Repository
{
    public partial class SundarNetDBContext : DbContext
    {
        static SundarNetDBContext()
        {
            Database.SetInitializer<SundarNetDBContext>(null);
        }
        public SundarNetDBContext()
            : base("Name=SundarNetDBContext")
        { }

        public SundarNetDBContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        { }

        public System.Data.Entity.DbSet<Sys_Module> Sys_Module { get; set; }
        public System.Data.Entity.DbSet<Sys_ModuleElement> Sys_ModuleElement { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new ());

            // InitializeMapping(modelBuilder);
        }
    }
}