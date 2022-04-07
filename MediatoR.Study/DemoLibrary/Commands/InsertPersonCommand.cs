using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Commands
{

    public record InsertPersonCommand(string FirstName, string LastName) : IRequest<PersonModel>;

    /*
     * Parameters are capitalized above because Records creates them as proprieties.
     * 
     * Record is replacing this class below

    public class InsertPersonCommand : IRequest<PersonModel>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public InsertPersonCommand(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
    */
}
