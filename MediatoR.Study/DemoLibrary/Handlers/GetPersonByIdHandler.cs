using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, PersonModel>
    {
        /*
         * Using only Mediator, filtering the results on the handler
         */
        private readonly IMediator _mediator;

        public GetPersonByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<PersonModel> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            var peopleList = await _mediator.Send(new GetPersonListQuery());
            var person = peopleList.FirstOrDefault(x => x.Id == request.Id);
            return person;
        }

        /*
         * Sample getting a person by ID directly from the data acess
         * 
        private readonly IDemoDataAccess _dataAccess;

        public GetPersonByIdHandler(IDemoDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public Task<PersonModel> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.GetPersonById(request.Id));
        }
        */
    }
}
