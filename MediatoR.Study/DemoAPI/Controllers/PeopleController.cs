using Microsoft.AspNetCore.Mvc;
using DemoLibrary.Queries;
using DemoLibrary.Models;
using DemoLibrary.Commands;
using MediatR;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private IMediator _mediator;

        public PeopleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<PeopleController>
        [HttpGet]
        public async Task<List<PersonModel>> Get()
        {
            return await _mediator.Send(new GetPersonListQuery());
        }

        // GET api/<PeopleController>/5
        [HttpGet("{id}")]
        public async Task<PersonModel> GetById(int id)
        {
            return await _mediator.Send(new GetPersonByIdQuery(id));
        }

        // POST api/<PeopleController>
        [HttpPost]
        public async Task<PersonModel> Post([FromBody] PersonModel value)
        {
            var model = new InsertPersonCommand(value.FirstName, value.LastName);
            return await _mediator.Send(model);
        }
    }
}
