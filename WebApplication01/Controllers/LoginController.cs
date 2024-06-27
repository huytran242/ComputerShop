﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication01.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }
        public IActionResult IndexLogin()
        {
            return View();
        }
    }
}
