using Dictionary.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Dictionary.Dal.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {    
        IQueryable<TEntity> GetByCondition(Expression<Func<TEntity,bool>>exprassion,bool trackChanged);
        void Add(TEntity entity);       
        void Delete(TEntity entity);     
        void Update(TEntity entity);     
    }
}
