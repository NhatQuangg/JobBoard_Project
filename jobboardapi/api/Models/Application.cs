using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Application
    {
        public int Id { get; set; }
        public string? CoverLetter { get; set; }
        public string? Status { get; set; }
        public DateTime? AppliedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int CandidateId { get; set; }
        public int JobId { get; set; }

        [ForeignKey("CandidateId")]
        public CandidateProfile Candidate { get; set; }

        [ForeignKey("JobId")]
        public JobPosting Job { get; set; }
    }
}