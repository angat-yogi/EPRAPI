using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LSStudentEmployeeAPI.Models;

namespace LSStudentEmployeeAPI.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<FTEReview> FTEReviews { get; set; }
        public DbSet<SelfEval> SelfEvals { get; set; }
        public DbSet<ShiftLead> ShiftLead { get; set; }
        public DbSet<TechCheck> TechCheck { get; set; }
        public DbSet<BagCheck> BagChecks { get; set; }
        //public DbSet<FTEReview> FTEReviews { get; set; }
    }
}
