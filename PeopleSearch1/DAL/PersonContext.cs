using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PeopleSearch1.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PeopleSearch1.DAL
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base("PersonContext")
        {

        }
        public DbSet<Person> Persons { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}