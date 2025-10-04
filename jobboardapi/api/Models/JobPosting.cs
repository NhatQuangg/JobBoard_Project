using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class JobPosting
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public string? SalaryRange { get; set; }
        public string? JobType { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ExpiresAt { get; set; }
        public string? Benefits { get; set; }
        public string? WorkArrangement { get; set; }
        public string? Duration { get; set; }
        public string? Requirements { get; set; }
        public string? WorkAuthorization { get; set; }
        public float? MinGPA { get; set; }
        public string? Major { get; set; }
        public int? ViewCount { get; set; }
        public int? ApplicationCount { get; set; }
        public int? SaveJob { get; set; }
        public string? Status { get; set; }
        // Foreign key
        public int EmployerID { get; set; }

        [ForeignKey("EmployerID")]
        public EmployerProfile Employer { get; set; }

        public ICollection<Application> Applications { get; set; }
    }
}