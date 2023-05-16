using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebApp.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Repositories.forDataContext
{
    //public class ProductRepository
    public class ProductRepository : DataRepository<ProductEntity>
    {
        public ProductRepository(DataContext dataContext) : base(dataContext)
        {
        }

        #region Repository
        /*
        public abstract class DataRepository<TEntity> where TEntity : class
        {

            private readonly DataContext _dataContext;
            protected DataRepository(DataContext dataContext)
            {
                _dataContext = dataContext;
            }





            public virtual async Task<TEntity> AddAsync(TEntity entity)
            {
                _dataContext.Set<TEntity>().Add(entity);
                await _dataContext.SaveChangesAsync();
                return entity;
            }





            public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
            {
                var entity = await _dataContext.Set<TEntity>().FirstOrDefaultAsync(expression);
                if (entity != null)
                    return entity;

                return null;
            }




            public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
            {
                return await _dataContext.Set<TEntity>().ToListAsync();
            }




            //filter using $expression
            public virtual async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression)
            {
                return await _dataContext.Set<TEntity>().Where(expression).ToListAsync();
            }





            public virtual async Task<TEntity> UpdateAsync(TEntity entity)
            {
                _dataContext.Set<TEntity>().Update(entity);
                await _dataContext.SaveChangesAsync();
                return entity;
            }





            public virtual async Task<bool> DeleteAsync(TEntity entity)
            {
                try
                {
                    _dataContext.Set<TEntity>().Remove(entity);
                    await _dataContext.SaveChangesAsync();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        */
        #endregion
    }
}
