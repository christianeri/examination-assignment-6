using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using WebApp.Contexts;

namespace WebApp.Repositories.forDataContext
{
    //www.youtube.com/watch?v=yGpybKyQlHo 02:29
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


        public virtual async Task<IEnumerable<TEntity>> GetAllAsync(int take)
        {
            return await _dataContext.Set<TEntity>().Take(take).ToListAsync();
        }


        //filter using $expression
        public virtual async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _dataContext.Set<TEntity>().Where(expression).ToListAsync();
        }        
        
        

        
        
        public virtual async Task<List<TEntity>> GetSelectedAsync(Expression<Func<TEntity, bool>> expression)
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
}
