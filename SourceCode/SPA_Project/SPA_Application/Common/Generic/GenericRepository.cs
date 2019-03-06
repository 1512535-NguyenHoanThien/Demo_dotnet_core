using Microsoft.EntityFrameworkCore;
using SPA_Application.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Common.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public DbContext _context;
        public DbSet<T> _table;

        public GenericRepository(IUnitOfWorkContext unitOfWorkContext)
        {
            this._context = unitOfWorkContext.GetUnitOfWorkContext() as DbContext;
            this._table = _context.Set<T>();
        }

        public void Create(T obj)
        {
            _table.Add(obj);
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return _table.ToList();
        }

        public T GetById(object id)
        {
            try
            {
                return _table.Find(id);
            }
            catch
            {
                return null;
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            _table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
    }
}
