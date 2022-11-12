using Dictionary.Dal.Access;
using Dictionary.Dal.Interfaces;
using Dictionary.Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Dal.Repositories
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        private readonly DictionaryDbContext _context;
        public RepositoryBase(DictionaryDbContext context)=> _context = context;
       
        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> exprassion,
            bool trackChanged) => trackChanged ?
             _context.Set<T>().Where(exprassion).AsNoTracking() :
             _context.Set<T>().Where(exprassion);


        public void Update(T entity) => _context.Set<T>().Update(entity);

        public void Delete(T entity) => _context.Set<T>().Remove(entity);

        public void Add(T entity) => _context.Set<T>().Add(entity);
    }
}
