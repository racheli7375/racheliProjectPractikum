using Microsoft.EntityFrameworkCore;
using ProjectPractikum.Repositories.Entities;
using ProjectPractikum.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPractikum.Repositories.Repositories
{
    public class ChildRepository:IChildRepository
    {
        private readonly IContext _context;

        public ChildRepository(IContext context)
        {
            _context = context;
        }
        public async Task<Child> AddAsync(Child c)
        {
            var c1 = _context.children.Add(c);

            await _context.SaveChangesAsync();
            return c1.Entity;
        }

        public async Task DeleteAsync(string id)
        {
            _context.children.Remove(await GetByIdAsync(id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.children.ToListAsync();
        }

        public async Task<Child> GetByIdAsync(string id)
        {
            return await _context.children.FindAsync(id);
        }

        public async Task<Child> UpdateAsync(Child c)
        {
            Child c1 = await GetByIdAsync(c.ChildId);
           c1.FirstName = c.FirstName;
            c1.DateOfBirth = c.DateOfBirth;
            await _context.SaveChangesAsync();
            return c1;
        }

    }
}
