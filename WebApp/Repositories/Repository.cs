using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebApp.Contexts;

namespace WebApp.Repositories
{
    public abstract class Repository<TEntity> where TEntity : class
    {


        private readonly UserContext _userContext;
        protected Repository(UserContext userContext)
        {
            _userContext = userContext;
        }





        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            _userContext.Set<TEntity>().Add(entity);
            await _userContext.SaveChangesAsync();
            return entity;
        }





        public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
        {
            var entity = await _userContext.Set<TEntity>().FirstOrDefaultAsync(expression);
            if(entity != null)
                return entity;
            
            return null;
        }




        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _userContext.Set<TEntity>().ToListAsync();
        }




        //filter using $expression
        public virtual async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _userContext.Set<TEntity>().Where(expression).ToListAsync();  
        }





        public virtual async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _userContext.Set<TEntity>().Update(entity);
            await _userContext.SaveChangesAsync();
            return entity;
        }





        public virtual async Task<bool> DeleteAsync(TEntity entity)
        {
            try
            {
                _userContext.Set<TEntity>().Remove(entity);
                await _userContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
