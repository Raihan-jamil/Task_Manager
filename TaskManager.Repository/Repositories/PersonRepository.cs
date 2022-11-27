using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Database.Context;
using TaskManager.Database.Models;
using TaskManager.Repository.Contracts;

namespace TaskManager.Repository.Repositories
{
    public class PersonRepository : IPersonRepository
    {

        private readonly TaskManagerContext _taskManagerContext;
        public PersonRepository(TaskManagerContext taskManagerContext)
        {
            _taskManagerContext = taskManagerContext;
        }

        //Task<Person> CreatePerson(Person person);
        public async Task<Person> CreatePerson(Person person)
        {         
            _taskManagerContext.Persons.Add(person);
            await _taskManagerContext.SaveChangesAsync();
            return person;
        }
        //Task<List<Person>> GetAll();
        public async Task<List<Person>> GetAll()
        {
            return await _taskManagerContext.Persons.ToListAsync();
        }
        //Task<Person> GetPersonByName(string name);
        public async Task<Person> GetPersonByName(string name)
        {
            return await _taskManagerContext.Persons.FirstOrDefaultAsync(x => x.Name == name);
        }
        //Task<Person> UpdatePersonById(Person person, int id);
        public async Task<Person> UpdatePersonById(Person person ,int id)
        {
            Person person2 = await _taskManagerContext.Persons.FindAsync(id);
            person2.Name = person.Name;
            

            await _taskManagerContext.SaveChangesAsync();

            return person2;
        }
    }
}
