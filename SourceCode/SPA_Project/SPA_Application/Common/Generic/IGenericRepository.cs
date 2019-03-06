using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Common.Generic
{
    public interface IGenericRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);

        void Create(T obj);
        void Update(T obj);
        void Delete(object id);
        void SaveChanges();    
    }
}
