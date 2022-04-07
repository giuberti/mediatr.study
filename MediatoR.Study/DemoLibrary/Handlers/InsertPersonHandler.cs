using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, PersonModel>
    {
        private IDemoDataAccess _data;

        public InsertPersonHandler(IDemoDataAccess data)
        {
            _data = data;
        }
        public async Task<PersonModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_data.InsertPerson(request.FirstName, request.LastName));
        }
    }
}
