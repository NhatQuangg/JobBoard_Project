using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class JobCategory_Posting
    {
        public int Id { get; set; }
        public bool? IsPrimary { get; set; }
        public int CategoryId { get; set; }
        public int JobId { get; set; }

        public JobPosting Job { get; set; }
        public JobCategory Category { get; set; }
    }
}