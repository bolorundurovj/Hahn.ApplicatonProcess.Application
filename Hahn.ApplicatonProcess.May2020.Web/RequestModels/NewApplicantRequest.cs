using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.May2020.Web.RequestModels
{
    public class NewApplicantRequest
    {
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Surname { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 10)]
        public string Address { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [Range(20, 60)]
        public int Age { get; set; }

        [Required]
        public bool Hired { get; set; }
    }
}
