using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mustang.Database.Repository
{
    public interface IRepository<TEntity,  Tkey> where TEntity : class
    {
        Task<TEntity> AddAsync(TEntity entity);
        void AddRangeAsync(List<TEntity> entities);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
        void DeleteRange(List<TEntity> entities);
        IQueryable<TEntity> GetQueryable();
        Task<TEntity> GetByIdAsync(Tkey Id);

        Task<List<TEntity>> GetAllAsync(bool asNoTRacking = false);
        Task<TEntity> GetAync(Expression<Func<TEntity, bool>> expression = null);
    }
}
