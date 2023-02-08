using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectPractikum.Repositories.Interfaces;
using ProjectPractikum.Repositories.Entities;

namespace ProjectPractikum.Context
{
    public class MyDbContext:DbContext,IContext
    {
        public DbSet<Person> people { get; set; }
        public DbSet<Child> children { get; set; }
      

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=RacheliBsDb;Trusted_connection=True");
        }
    }
}
