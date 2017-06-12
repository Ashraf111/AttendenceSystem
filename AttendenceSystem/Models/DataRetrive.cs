using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AttendenceSystem.Models
{
    public class DataRetrive:DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<YearTerm> YearTerms { get; set; }
        public DbSet<SubjectList> Subjectlist { get; set; }
        public DbSet<CsteY4_T2_Students> Cstey4t2studens { get; set; }
        public DbSet<Student> students { get; set; }
    }
}