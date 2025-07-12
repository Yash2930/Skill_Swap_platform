using Microsoft.AspNetCore.Mvc;
using SkillSwapPlatform2.Models;
using System.Diagnostics;

namespace SkillSwapPlatform2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var users = new List<USER>
        {
            new USER {
                FullName = "Marc Demo",
                ProfilePhotoUrl = "/image/python.jpg",
                SkillsOffered = new List<string>{ "JavaScript", "Python" },
                SkillsWanted = new List<string>{ "Photoshop", "Graphic Design" },
                Rating = 4.9
            },
            // Add more demo users here
        };
            return View(users);
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
