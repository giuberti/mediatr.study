using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Queries
{
    public record GetPersonByIdQuery(int Id) : IRequest<PersonModel>;

    /*
     Record is replacing a classe like below. Its more simple and it works pretty well with MediatR

    public class GetPersonByIdQuery
    {
        public int pId { get; set; }

        public GetPersonByIdQuery(int Id)
        {
            pId = Id;
        }
    }
*/
}
