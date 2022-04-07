using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    /// <summary>
    /// Interface can be useful if I create a class that acctually go to a database and does the real job.
    /// </summary>
    public interface IDemoDataAccess
    {
        List<PersonModel> GetPeople();
        PersonModel InsertPerson(string firstName, string lastName);
        PersonModel GetPersonById(int Id);
    }
}