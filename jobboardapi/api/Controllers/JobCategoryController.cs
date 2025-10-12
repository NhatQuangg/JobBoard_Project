using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.JobCategory;
using api.Interfaces;
using api.Mappers;
using api.Models;
using api.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("api/jobcategory")]
    [ApiController]
    public class JobCategoryController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IJobCategoryRepository _jobCategoryRepo;

        public JobCategoryController(
            ApplicationDBContext context,
            IJobCategoryRepository jobCategoryRepo
        )
        {
            _jobCategoryRepo = jobCategoryRepo;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var jobcategories = await _jobCategoryRepo.GetAllAsync();

            var jobCategoryDto = jobcategories.Select(j => j.ToJobCategoryDto()).ToList();

            return Ok(jobCategoryDto);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var jobcategory = await _jobCategoryRepo.GetByIdAsync(id);

            if (jobcategory == null)
                return NotFound();

            var jobCategoryDto = jobcategory.ToJobCategoryDto();

            return Ok(jobCategoryDto);
        }
    }
}
