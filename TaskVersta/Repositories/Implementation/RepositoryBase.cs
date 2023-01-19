using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TaskVersta.Data;
using TaskVersta.Repositories.Interfaces;

namespace TaskVersta.Repositories.Implementation
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T>
        where T : class
    {
        protected ApplicationDbContext _db { get; set; }

        public RepositoryBase(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<T>> FindAll()
        {
            return await _db.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return await _db.Set<T>()
                .Where(expression)
                .ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await _db.Set<T>().AddAsync(entity);
        }

        public async Task AddRangeAsync(params T[] entities)
        {
            await _db.Set<T>().AddRangeAsync(entities);
        }

        public void Update(T entity)
        {
            _db.Set<T>().Update(entity);
        }

        public void Remove(T entity)
        {
            _db.Set<T>().Remove(entity);
        }

        public void RemoveRange(params T[] entities)
        {
            _db.Set<T>().RemoveRange(entities);
        }
    }
}
