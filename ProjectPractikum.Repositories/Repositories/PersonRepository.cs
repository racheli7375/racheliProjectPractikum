using Microsoft.EntityFrameworkCore;
using ProjectPractikum.Repositories.Entities;
using ProjectPractikum.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPractikum.Repositories.Repositories
{
    public class PersonRepository:IPersonRepository
    {
        private readonly IContext _context;

        public PersonRepository(IContext context)
        {
            _context = context;
        }
        public async Task<Person> AddAsync(Person p)
        {
            var p1 = _context.people.Add(p);

            await _context.SaveChangesAsync();
            return p1.Entity;
        }

        public async Task DeleteAsync(string id)
        {
            _context.people.Remove(await GetByIdAsync(id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Person>> GetAllAsync()
        {
            return await _context.people.ToListAsync();
        }

        public async Task<Person> GetByIdAsync(string id)
        {
            return await _context.people.FindAsync(id);
        }

        public async Task<Person> UpdateAsync(Person p)
        {
            Person p1 = await GetByIdAsync(p.PersonId);
            p1.FirstName = p.FirstName;
            p1.LastName = p.LastName;
            p1.DateOfBirth = p.DateOfBirth;
            p1.Gender = p.Gender;
            p1.HMO = p.HMO;
            await _context.SaveChangesAsync();
            return p1;
        }
    }
}
