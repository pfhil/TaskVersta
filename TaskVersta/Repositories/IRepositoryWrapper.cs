using TaskVersta.Repositories.Interfaces;

namespace TaskVersta.Repositories
{
    public interface IRepositoryWrapper
    {
        IOrderRepository Orders { get; }
        Task SaveAsync();
    }
}
