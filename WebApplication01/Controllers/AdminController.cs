using Microsoft.AspNetCore.Mvc;

namespace WebApplication01.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

        public IActionResult IndexAdmin()
        {
            return View();
        }

    }
}
