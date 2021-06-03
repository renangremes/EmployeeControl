using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeControl.Models;

namespace EmployeeControl.Data
{
    public class EmployeeControlContext : DbContext
    {
        public EmployeeControlContext (DbContextOptions<EmployeeControlContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeControl.Models.Employee> Employees { get; set; }

        public DbSet<EmployeeControl.Models.Company> Company { get; set; }

        public DbSet<EmployeeControl.Models.Appointment> Appointment { get; set; }
    }
}
