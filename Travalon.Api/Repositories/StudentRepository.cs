using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travalon.Api.Database;
using Travalon.Api.Models;

namespace Travalon.Api.Repositories
{
    public class StudentRepository: IRepository<Student>
    {
        CoreContext _context;

        public StudentRepository(CoreContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> GetAll()
        {
            return await _context.Students.ToListAsync();
        }
    }
}
