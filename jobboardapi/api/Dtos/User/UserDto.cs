using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.User
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public int Role { get; set; } // 0: Admin, 1: Employer, 2: Candidate
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
