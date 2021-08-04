using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.DataAccessLayer
{
    public class EmployeeDeactivationContext : DbContext
    {
        public EmployeeDeactivationContext(DbContextOptions<EmployeeDeactivationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Models.EmployeeDeactivation> Employee { get; set; }
        
    }
}
