using Hahn.ApplicatonProcess.May2020.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hahn.ApplicatonProcess.May2020.Data
{
    public class ApplicantsDbContext : DbContext
    {
        public ApplicantsDbContext() { }
        public ApplicantsDbContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Applicant> Applicants { get; set; }
        public virtual DbSet<UserApplication> UserApplications { get; set; }
    }
}
