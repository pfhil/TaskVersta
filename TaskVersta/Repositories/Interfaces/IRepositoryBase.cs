using System.Linq.Expressions;

namespace TaskVersta.Repositories.Interfaces
{
    public interface IRepositoryBase<T>
    {
        Task<IEnumerable<T>> FindAll();
        Task<IEnumerable<T>> FindByCondition(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(params T[] entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(params T[] entities);
    }
}
