using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travalon.Api.Models;
using Travalon.Api.Models.Exceptions;
using Travalon.Api.Repositories;

namespace Travalon.Api.Services
{
    public class StudentService: IService<Student>
    {
        IRepository<Student> _repo;

        public StudentService(IRepository<Student> repo)
        {
            _repo = repo;
        }

        public async Task Create(Student obj)
        {
            await _repo.Create(obj);
        }

        public async Task<ICollection<Student>> GetAll()
        {
            return await _repo.GetAll();
        }

        public ICollection<Student> GetWithFilter(List<KeyValuePair<string, string>> filters)
        {
            throw new NotImplementedException();
        }

        public async Task<Student> GetById(long id)
        {
            return await _repo.GetById(id);
        }

        public async Task Update(Student obj)
        {
            await _repo.Update(obj);
        }

        public async Task Delete(long id)
        {
            var student = await _repo.GetById(id);

            if (student == null)
            {
                throw new ItemNotFoundException("Could not find student with selected ID");
            }

            await _repo.Delete(student);
        }
    }
}
