using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.JobCategory;
using api.Models;

namespace api.Mappers
{
    public static class JobCategoryMappers
    {
        public static JobCategoryDto ToJobCategoryDto(this JobCategory jobcategory)
        {
            return new JobCategoryDto
            {
                Id = jobcategory.Id,
                CategoryName = jobcategory.CategoryName,
                Description = jobcategory.Description,
            };
        }
    }
}
