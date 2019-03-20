using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PeopleSearch1.Models;

namespace PeopleSearch1.DAL
{
    public class PersonInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PersonContext>
    {
        protected override void Seed(PersonContext context)
        {
            var persons = new List<Person>
            {
            new Person{Id=1,LastName="SCOTT",FirstName="MICHAEL", Address= "Scranton", Age = 47, Interests = "Improv", PicUrl = "TODO"},
            new Person{Id=2,LastName="HALPERT",FirstName="JIM", Address= "New York", Age = 32, Interests = "Sports", PicUrl = "TODO"},

            };

            persons.ForEach(s => context.Persons.Add(s));
            context.SaveChanges();
            
        }
    }
}