using ProjectPractikum.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPractikum.Repositories.Interfaces
{
    public interface IPersonRepository
    {
        Task<List<Person>> GetAllAsync();

        Task<Person> GetByIdAsync(string id);

        Task<Person> AddAsync(Person p);
        Task<Person> UpdateAsync(Person p);
        Task DeleteAsync(string id);
    }
}
