using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Interfaces
{
    public interface IJobCategoryRepository
    {
        Task<List<JobCategory>> GetAllAsync();
        Task<JobCategory?> GetByIdAsync(int id);
    }
}
