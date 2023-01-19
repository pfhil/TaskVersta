using TaskVersta.Data;
using TaskVersta.Models;
using TaskVersta.Repositories.Interfaces;

namespace TaskVersta.Repositories.Implementation
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
