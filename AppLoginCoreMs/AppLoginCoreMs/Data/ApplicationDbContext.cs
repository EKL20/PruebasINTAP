using AppLoginCoreMs.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace AppLoginCoreMs.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> employee { get; set; }
        public DbSet<Activities> activities { get; set; }
        public DbSet<Time> time { get; set; }
    }
}
