using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }

        // =======================================
        // public int EmployerId { get; set; }
        // [ForeignKey(nameof(EmployerId))]
        // public EmployerProfile EmployerProfile { get; set; }


        // =======================================
        public CandidateProfile? CandidateProfile { get; set; }
        // public int CandidateId { get; set; }
        // [ForeignKey(nameof(CandidateId))]
        // public CandidateProfile CandidateProfile { get; set; }


        // =======================================
        // [InverseProperty("Sender")]
        // public virtual ICollection<Message> SentMessages { get; set; } = new List<Message>();

        // [InverseProperty("Receiver")]
        // public virtual ICollection<Message> ReceivedMessages { get; set; } = new List<Message>();
        
    }
}