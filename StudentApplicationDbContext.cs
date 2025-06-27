using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentRegistrationApp_Project.Models
{
    public class StudentApplicationDbContext : DbContext
    {
        public StudentApplicationDbContext() : base("StudentApplicationDbContext") { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
    }
}