using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyDocument4.Domain;
using MyDocument4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyDocument4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserRepository userRepository;

        public HomeController(ILogger<HomeController> logger, UserRepository userRepository)
        {
            _logger = logger;
            this.userRepository = userRepository;
        }

        public IActionResult Index(Guid id)
        {
            User model = id == default ? new User() : userRepository.GetUserById(id);
            return View(model);
        }

        public IActionResult Submit()
        {
            
            var model = userRepository.GetLastUser(userRepository.GetUsers());
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(User model)
        {
            var models = userRepository.GetUsers();
            if (ModelState.IsValid)
            {
                userRepository.SaveUser(model, models);
                return RedirectToAction("Submit");
            }
            return View(model);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
