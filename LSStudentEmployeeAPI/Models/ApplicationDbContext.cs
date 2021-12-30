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
        public DbSet<User> Users { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<ShiftResponse> ShiftResponses { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<TimesResponse> TimesResponses { get; set; }
        public DbSet<Time> Times { get; set; }
        public DbSet<UnadjustedPoints> UnadjustedPoints { get; set; }

        //public DbSet<FTEReview> FTEReviews { get; set; }
    }
}
