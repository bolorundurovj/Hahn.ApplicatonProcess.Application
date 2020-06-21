using System;
using System.Collections.Generic;
using System.Linq;
using Hahn.ApplicatonProcess.May2020.Data;
using Hahn.ApplicatonProcess.May2020.Data.Models;

namespace Hahn.ApplicatonProcess.May2020.Domain
{
    public class ApplicantService : IApplicantService
    {
        private readonly ApplicantsDbContext _db;
        public ApplicantService(ApplicantsDbContext db)
        {
            _db = db;
        }
        public List<Applicant> GetAllApplicants()
        {
            return _db.Applicants.ToList();
        }

        public Applicant GetApplicant(int applicantId)
        {
            return _db.Applicants.Find(applicantId);
        }

        public void AddApplicant(Applicant applicant)
        {
            _db.Add(applicant);
            _db.SaveChanges();
        }

        public void DeleteApplicant(int applicantId)
        {
            var personToDelete = _db.Applicants.Find(applicantId);
            if(personToDelete != null)
            {
                _db.Remove(personToDelete);
                _db.SaveChanges();
            }

            else
            {
                throw new InvalidOperationException("Can't delete a person that does not exist");
            }
        }

        public void UpdateApplicant(Applicant applicant)
        {
            _db.Entry(applicant).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
