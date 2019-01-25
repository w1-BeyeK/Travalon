using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travalon.Api.Services
{
    public interface IService<T>
    {
        Task<ICollection<T>> GetAll();
        Task<T> GetById(long id);
        ICollection<T> GetWithFilter(List<KeyValuePair<string, string>> filters);
        Task Create(T obj);
        Task Update(T obj);
        Task Delete(long id);
    }
}
