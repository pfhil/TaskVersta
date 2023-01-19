using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskVersta.Models.ViewModels;

namespace TaskVersta.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Warning()
        {
            var statusCode = Response.StatusCode;

            switch (statusCode)
            {
                case 403:
                    return View(new WarningViewModel { WarningText = "Вам запрещен доступ к данному ресурсу" });
                case 404:
                    return View(new WarningViewModel { WarningText = "Запрошенный ресурс не может быть найден" });
                default:
                    return View(new WarningViewModel { WarningText = $"Статусный код: {statusCode}" });
            }

        }
    }
}