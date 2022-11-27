using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Database.Models;
using TaskManager.Service.Contracts;
using TaskManager.Service.Helpers.DTOs;

namespace TaskManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        //Task<List<Person>> GetAll();
        [HttpGet("/api/persons")]
        public async Task<List<Person>> GetAll()
        {
            return await _personService.GetAll();
        }

        //Task<Person> CreatePerson(Person person);
        [HttpPost("/api/persons")]
        public async Task<Person> CreatePerson(PersonDto person)
        {
            Person person1 = await _personService.CreatePerson(person);
            return person1;
        }


        //Task<Person> GetPersonByName(string name);
        [HttpGet("/api/persons/{name}")]
        public async Task<Person> GetPersonByName(string name)
        {
            return await _personService.GetPersonByName(name);
        }

        //Task<Person> UpdatePersonById(Person person, int id);

        [HttpPut("/api/persons/{id}")]
        public async Task<Person> UpdateUserById(PersonDto person,int id)
        {
            return await _personService.UpdatePersonById(person, id);
        }
    }
}
