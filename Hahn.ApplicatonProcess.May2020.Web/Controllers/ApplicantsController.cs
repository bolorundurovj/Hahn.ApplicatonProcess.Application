using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hahn.ApplicatonProcess.May2020.Domain;
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
    }
}
