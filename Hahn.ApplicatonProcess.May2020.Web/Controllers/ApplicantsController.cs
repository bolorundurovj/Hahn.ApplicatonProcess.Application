using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Hahn.ApplicatonProcess.May2020.Web.Controllers
{
    [ApiController]
    public class ApplicantsController : ControllerBase
    {
        private readonly ILogger<ApplicantsController> _logger;

        public ApplicantsController(ILogger<ApplicantsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/api/applicants")]
        public ActionResult GetApplicants()
        {
            return Ok("Applicants !!");
        }
    }
}
