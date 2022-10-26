using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ScavengeRUS.Models;
using ScavengeRUS.Models.Entities;
using ScavengeRUS.Services;
using System.Diagnostics;

namespace ScavengeRUS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPlayerRepository _playerRepo;

        public HomeController(ILogger<HomeController> logger, IPlayerRepository playerRepo)
        {
            _logger = logger;
            _playerRepo = playerRepo;
        }

        public IActionResult Index()
        {
            return View();
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