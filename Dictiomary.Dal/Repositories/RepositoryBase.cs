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
    public abstract class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {

        protected DictionaryDbContext Context { get; set; }
        public RepositoryBase(DictionaryDbContext dictionaryDb) => Context = dictionaryDb;


        public  IQueryable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().AsNoTracking();
        }

        public IQueryable<TEntity> GetByCondition(Expression<Func<TEntity
            , bool>> condition)
        {
            var word = Context.Set<TEntity>().Where(condition).AsNoTracking();
            return word;
        }

        public void Update(TEntity entity)
        {
            Context.Set<TEntity>().Update(entity);
        }
        public void Create(TEntity entity)
        {
            Context.Set<TEntity>().AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

    }
}
