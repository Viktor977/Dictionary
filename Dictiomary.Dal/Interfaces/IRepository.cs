using Dictionary.Dal.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dictionary.Dal.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task AddAsync(TEntity entity);       
        void Delete(TEntity entity);     
        void Update(TEntity entity);     
    }
}
