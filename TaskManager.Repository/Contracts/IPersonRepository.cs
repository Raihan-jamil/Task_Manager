using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Database.Models;

namespace TaskManager.Repository.Contracts
{
    public interface IPersonRepository
    {
        Task<Person> CreatePerson(Person person);
        Task<List<Person>> GetAll();
        Task<Person> GetPersonByName(string name);
        Task<Person> UpdatePersonById(Person person, int id);
 
    }
}
