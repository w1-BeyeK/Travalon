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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudent(long id)
        {
            try
            {
                Student std = await _service.GetById(id);
                return Ok(std);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent([FromBody]Student std)
        {
            try
            {
                await _service.Create(std);
                return Created("", std);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudent(long id, [FromBody]Student std)
        {
            try
            {
                if(id != std.StudentID)
                {
                    return BadRequest();
                }

                await _service.Update(std);
                return NoContent();
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(long id)
        {
            try
            {
                await _service.Delete(id);
                return NoContent();
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}