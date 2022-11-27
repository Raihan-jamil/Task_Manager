using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Database.Models;
using TaskManager.Service.Helpers.DTOs;

namespace TaskManager.Service.Contracts
{
    public interface IPersonService
    {
        Task<Person> CreatePerson(PersonDto person);
        Task<List<Person>> GetAll();
        Task<Person> GetPersonByName(string name);
        Task<Person> UpdatePersonById(PersonDto person, int id);
    }
}
