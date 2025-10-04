using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Interview
    {
        public int Id { get; set; }
        public string? InterviewType { get; set; }
        public string? Location { get; set; }
        public string? Status { get; set; }
        public string? Notes { get; set; }
        public DateTime? ScheduledAt { get; set; }
        public int ApplicationId { get; set; }
        public Application Application { get; set; }
    }
}