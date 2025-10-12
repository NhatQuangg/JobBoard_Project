using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class JobCategoryRepository : IJobCategoryRepository
    {
        private readonly ApplicationDBContext _context;

        public JobCategoryRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<List<JobCategory>> GetAllAsync()
        {
            var jobcategories = await _context.JobCategories.ToListAsync();

            return jobcategories;
        }

        public async Task<JobCategory?> GetByIdAsync(int id)
        {
            var jobcategory = await _context.JobCategories.FindAsync(id);

            return jobcategory;
        }
    }
}
