using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PeopleSearch1.Models;

namespace PeopleSearch1.DAL
{   
   
    public class PersonInitializer : System.Data.Entity.DropCreateDatabaseAlways<PersonContext>
    {
        protected override void Seed(PersonContext context)
        {
            var persons = new List<Person>
            {
            new Person{Id=1,LastName="SCOTT",FirstName="MICHAEL", Address= "Scranton", Age = 47, Interests = "Improv", PicUrl = "http://clipart-library.com/newimages/american-flag-clip-art-1.jpg"},
            new Person{Id=2,LastName="HALPERT",FirstName="JIM", Address= "New York", Age = 32, Interests = "Sports", PicUrl = "TODO"},
            new Person{Id=3,LastName="SCHRUTE",FirstName="DWIGHT", Address= "Scranton", Age = 36, Interests = "Farming", PicUrl = "https://m.media-amazon.com/images/M/MV5BMTQwNDM1MjQ0M15BMl5BanBnXkFtZTcwNTkzNDczMg@@._V1_UY44_CR0,0,32,44_AL_.jpg"},
            new Person{Id=4,LastName="MARTIN",FirstName="ANGELA", Address= "New York", Age = 35, Interests = "Cats", PicUrl = "TODO"},
            new Person{Id=5,LastName="HOWARD",FirstName="RYAN", Address= "New York", Age = 27, Interests = "Twitter", PicUrl = "TODO"},
                                 
            };

            persons.ForEach(s => context.Persons.Add(s));
            context.SaveChanges();
            
        }
    }
}