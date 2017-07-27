using MVC7days.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC7days.DataAccessLayer
{
    public class Mvc5in7daysDB: DbContext
    {

        public DbSet<Employee> Employees { get; set; }

        //tabelite sto se kreiraat vo bazata go dobivat imeto
        //od zagradata
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("TblEmployee");
            base.OnModelCreating(modelBuilder);
        }
    }
}