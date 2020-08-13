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
    public class vwCourseStudentCountController : ControllerBase
    {

        private readonly ContosouniversityContext _context;

        public vwCourseStudentCountController(ContosouniversityContext context)
        {
            _context = context;
        }
        // GET: api/<vwCourseStudentCountController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_context.VwCourseStudentCount
            .FromSqlRaw(@"SELECT [DepartmentID],[Name],[CourseID],[Title],[StudentCount]
              FROM [ContosoUniversity].[dbo].[vwCourseStudentCount]")
            .ToList()
            );
        }
    }
}
