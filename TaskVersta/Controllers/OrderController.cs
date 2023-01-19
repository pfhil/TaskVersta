using Microsoft.AspNetCore.Mvc;
using TaskVersta.Models;
using TaskVersta.Repositories;

namespace TaskVersta.Controllers
{
    public class OrderController : Controller
    {
        private readonly IRepositoryWrapper _db;

        public OrderController(IRepositoryWrapper db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var orders = await _db.Orders.FindAll();
            return View(orders);
        }

        //GET - Insert
        [HttpGet]
        public IActionResult Insert()
        {
            var order = new Order();
            return View(order);
        }

        //Post - Insert
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Insert(Order order)
        {
            if (ModelState.IsValid)
            {
                await _db.Orders.AddAsync(order);
                await _db.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        //GET - Details
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var order = (await _db.Orders.FindByCondition(o => o.Id == id)).FirstOrDefault();
            if (order != null)
            {
                return View(order);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
