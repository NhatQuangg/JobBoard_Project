using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class SavedJob
    {
        public int Id { get; set; }
        public DateTime? SavedAt { get; set; }
        public int JobId { get; set; }
        public int CandidateId { get; set; }

        public CandidateProfile Candidate { get; set; }
        public JobPosting Job { get; set; }
    }
}