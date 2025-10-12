using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class CandidateProfile
    {
        public int Id { get; set; }
        public string? Phone { get; set; }
        public string? Location { get; set; }
        public string? ResumeURL { get; set; }
        public string? Education { get; set; }
        public string? Bio { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // ===================================
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
