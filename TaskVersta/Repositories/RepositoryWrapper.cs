using TaskVersta.Data;
using TaskVersta.Repositories.Interfaces;

namespace TaskVersta.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly ApplicationDbContext _db;
        private readonly IOrderRepository _orderRepository;

        public RepositoryWrapper(ApplicationDbContext db, IOrderRepository orderRepository)
        {
            _db = db;
            _orderRepository = orderRepository;
        }

        public IOrderRepository Orders => _orderRepository;

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
