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

        public async Task<Student> GetById(long id)
        {
            return await _context.Students.Where(s => s.StudentID == id).FirstOrDefaultAsync();
        }

        public async Task Create(Student std)
        {
            _context.Students.Add(std);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Student std)
        {
            _context.Entry(std).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Student std)
        {
            _context.Students.Remove(std);
            await _context.SaveChangesAsync();
        }
    }
}
