using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class JobCategory
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }

        public ICollection<JobCategory_Posting> JobPostings { get; set; }
    }
}