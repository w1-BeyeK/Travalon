using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Travalon.Api.Models;
using Travalon.Api.Services;

namespace Travalon.Api.Controllers
{
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        IService<Student> _service;

        public StudentsController(IService<Student> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                ICollection<Student> students = await _service.GetAll();
                return Ok(students);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}