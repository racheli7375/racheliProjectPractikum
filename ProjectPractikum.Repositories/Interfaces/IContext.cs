using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using ProjectPractikum.Repositories.Entities;

namespace ProjectPractikum.Repositories.Interfaces
{
    public interface IContext
    {
        DbSet<Child> children { get; set; }

        DbSet<Person> people { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellation = default);
    }
}
