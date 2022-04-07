using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    /// <summary>
    /// Emulates a simple Database
    /// </summary>
    public class DemoDataAccess : IDemoDataAccess
    {
        private List<PersonModel> _people = new();   // new sintax for C# 9, avoiding rewrite new List<Person...

        public DemoDataAccess()
        {
            _people.Add(new PersonModel { Id = 1, FirstName = "Giovani", LastName = "Giuberti" });
            _people.Add(new PersonModel { Id = 2, FirstName = "Pammela", LastName = "Bisley" });
            _people.Add(new PersonModel { Id = 3, FirstName = "Michael", LastName = "Scott" });
        }

        public List<PersonModel> GetPeople()
        {
            return _people;
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel model = new() { FirstName = firstName, LastName = lastName };
            model.Id = _people.Max(x => x.Id) + 1;
            _people.Add(model);
            return model;
        }

        public PersonModel GetPersonById(int Id)
        {
            foreach (PersonModel model in _people)
            {
                if (model.Id == Id)
                    return model;
            }
            return null;
        }
    }

}
