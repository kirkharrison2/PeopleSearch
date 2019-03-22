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
                // TODO finish addig profile pics
            new Person{Id=1,LastName="Beesly",FirstName="Pam", Address= "New York", Age = 30, Interests = "Art", PicUrl = "https://i.imgur.com/jbDoZGn.png"},
            new Person{Id=2,LastName="Bernard",FirstName="Andy", Address= "Ithica", Age = 33, Interests = "Singing", PicUrl = "https://i.imgur.com/HEg3cqT.png"},
            new Person{Id=3,LastName="Hudson",FirstName="Stanley", Address= "Pittsburgh", Age = 51, Interests = "Sudoku", PicUrl = "https://i.imgur.com/d2k42lO.png"},
            new Person{Id=4,LastName="Scott",FirstName="Michael", Address= "Scranton", Age = 47, Interests = "Improv", PicUrl = "https://i.imgur.com/63YeTGo.png"},
            new Person{Id=5,LastName="Halpert",FirstName="Jim", Address= "New York", Age = 32, Interests = "Sports", PicUrl = "https://i.imgur.com/bvt1mkE.png"},
            new Person{Id=6,LastName="Schrute",FirstName="Dwight", Address= "Scranton", Age = 36, Interests = "Farming", PicUrl = "https://i.imgur.com/cGZnMdb.png"},
            new Person{Id=7,LastName="Martin",FirstName="Angela", Address= "New York", Age = 35, Interests = "Cats", PicUrl = "https://i.imgur.com/jZbiGnH.png"},
            new Person{Id=8,LastName="Howard",FirstName="Ryan", Address= "New York", Age = 27, Interests = "Twitter", PicUrl = "https://i.imgur.com/358GPJX.png"},
            new Person{Id=9,LastName="Martinez",FirstName="Oscar", Address= "New York", Age = 34, Interests = "Trivia", PicUrl = "https://i.imgur.com/sJ9Vahf.png"},
            new Person{Id=10,LastName="Bratton",FirstName="Creed", Address= "Los Angeles", Age = 58, Interests = "Unknown", PicUrl = "https://i.imgur.com/CoqY4CS.png"},
            new Person{Id=11,LastName="Malone",FirstName="Kevin", Address= "Scranton", Age = 37, Interests = "Cooking", PicUrl = "https://i.imgur.com/lDr4nZH.png"},
            new Person{Id=12,LastName="Flenderson",FirstName="Toby", Address= "New York", Age = 41, Interests = "Travel", PicUrl = "https://i.imgur.com/DXduBKT.png"},
            };

            persons.ForEach(s => context.Persons.Add(s));
            context.SaveChanges();
            
        }
    }
}