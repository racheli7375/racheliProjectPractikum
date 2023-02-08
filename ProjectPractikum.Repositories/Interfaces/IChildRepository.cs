using ProjectPractikum.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPractikum.Repositories.Interfaces
{
    public interface IChildRepository
    {
        Task<List<Child>> GetAllAsync();

        Task<Child> GetByIdAsync(string id);

        Task<Child> AddAsync(Child c);
        Task<Child> UpdateAsync(Child c);
        Task DeleteAsync(string id);
    }
}
