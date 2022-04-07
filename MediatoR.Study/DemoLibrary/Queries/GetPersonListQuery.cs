using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Queries
{
    public record GetPersonListQuery() : IRequest<List<PersonModel>>;

    /*
     Record is replacing a simples classe like below:
    Record is immutable by default

    public class GetPersonListQuery() : IRequest<List<PersonModel>>
    {
    }
      
    */
}
