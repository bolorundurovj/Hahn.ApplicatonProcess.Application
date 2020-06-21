using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hahn.ApplicatonProcess.May2020.Data.Models;
using Hahn.ApplicatonProcess.May2020.Domain;
using Hahn.ApplicatonProcess.May2020.Web.RequestModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Hahn.ApplicatonProcess.May2020.Web.Controllers
{
    [ApiController]
    public class ApplicantsController : ControllerBase
    {
        private readonly ILogger<ApplicantsController> _logger;
        private IApplicantService _applicantService;

        public ApplicantsController(ILogger<ApplicantsController> logger, IApplicantService applicantService)
        {
            _logger = logger;
            _applicantService = applicantService;
        }

        [HttpGet("/api/applicants")]
        public ActionResult GetApplicants()
        {
            var applicants = _applicantService.GetAllApplicants();
            return Ok(applicants);
        }

        [HttpPost("/api/applicants")]
        public ActionResult CreateApplicant([FromBody] NewApplicantRequest applicantRequest)
        {
            var now = DateTime.UtcNow;
            var applicant = new Applicant
            {
                CreatedOn = now,
                UpdatedOn = now,
                Name = applicantRequest.Name,
                Surname = applicantRequest.Surname,
                Country = applicantRequest.Country,
                Address = applicantRequest.Address,
                Age = applicantRequest.Age,
                Email = applicantRequest.Email,
                Hired = applicantRequest.Hired,
            };
            _applicantService.AddApplicant(applicant);
            return Ok($"Applicant Created: {applicant.Name}");
        }
    }
}
