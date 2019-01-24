using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travalon.Api.Models;
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

        public bool Add(Student obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Student obj)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Student>> GetAll()
        {
            return await _repo.GetAll();
        }

        public ICollection<Student> GetWithFilter(List<KeyValuePair<string, string>> filters)
        {
            throw new NotImplementedException();
        }

        public bool Update(Student obj)
        {
            throw new NotImplementedException();
        }
    }
}
