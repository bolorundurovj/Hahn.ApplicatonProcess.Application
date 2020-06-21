using System.Collections.Generic;
using Hahn.ApplicatonProcess.May2020.Data.Models;

namespace Hahn.ApplicatonProcess.May2020.Domain
{
    public interface IApplicantService
    {
        public List<Applicant> GetAllApplicants();
        public Applicant GetApplicant(int applicantId);
        public void AddApplicant(Applicant applicant);
        public void DeleteApplicant(int applicantId);
    }
}