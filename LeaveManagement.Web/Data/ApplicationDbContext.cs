﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }

        public DbSet<LeaveAllocation> AtributeNuevo { get; set; }

        public DbSet<LeaveAllocation> AtributeNuevo2 { get; set; }

        public DbSet<LeaveAllocation> AtributeNuevo3 { get; set; }

    }
}