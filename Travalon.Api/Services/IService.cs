using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travalon.Api.Services
{
    public interface IService<T>
    {
        Task<ICollection<T>> GetAll();
        ICollection<T> GetWithFilter(List<KeyValuePair<string, string>> filters);
        bool Add(T obj);
        bool Update(T obj);
        bool Delete(T obj);
    }
}
