using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travalon.Api.Repositories
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetById(long id);
        Task Create(T obj);
        Task Update(T obj);
        Task Delete(T obj);
    }
}
