using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Database.Context;
using TaskManager.Database.Models;
using TaskManager.Repository.Contracts;
using TaskManager.Service.Contracts;
using TaskManager.Service.Helpers.DTOs;

namespace TaskManager.Service.Services
{
    public class PersonService : IPersonService
    {
        public readonly IPersonRepository _personRepository;
        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        //Task<Person> CreatePerson(Person person);
        public async Task<Person> CreatePerson(PersonDto person)
        {
            Person person1 = new Person();
            person1.Name = person.Name;
            Person person2 = await _personRepository.CreatePerson(person1);
            return person2;
        }
        //Task<List<Person>> GetAll();
        public async Task<List<Person>> GetAll()
        {
            List<Person> persons = await _personRepository.GetAll();
            return persons;
        }
        //Task<Person> GetPersonByName(string name);
        public async Task<Person> GetPersonByName(string name)
        {
            return await _personRepository.GetPersonByName(name);
        }
        //Task<Person> UpdatePersonById(Person person, int id);
        public async Task<Person> UpdatePersonById(PersonDto person, int id)
        {
            Person person1 = new Person();
            person1.Name = person.Name;
            return await _personRepository.UpdatePersonById(person1, id);
        }

    }
}
