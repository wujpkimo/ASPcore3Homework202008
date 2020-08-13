using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPcore3Homework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPcore3Homework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class vwDepartmentCourseCountController : ControllerBase
    {
        private readonly ContosouniversityContext _context;

        public vwDepartmentCourseCountController(ContosouniversityContext context)
        {
            _context = context;
        }
        // GET: api/<vwDepartmentCourseCountController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_context.VwCourseStudentCount
            .FromSqlRaw(@"SELECT [DepartmentID],[Name],[CourseCount]  FROM [ContosoUniversity].[dbo].[vwDepartmentCourseCount]")
            .ToList()
            );
        }
    }
}