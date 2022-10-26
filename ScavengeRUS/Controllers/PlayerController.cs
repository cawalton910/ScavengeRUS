using Microsoft.AspNetCore.Mvc;
using ScavengeRUS.Models.Entities;
using ScavengeRUS.Services;

namespace ScavengeRUS.Controllers
{
    public class PlayerController : Controller
    {
        private readonly IPlayerRepository _playerRepo;

        public PlayerController(IPlayerRepository playerRepo)
        {
            _playerRepo = playerRepo;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Player newPlayer)
        {
            if (ModelState.IsValid)
            {
                await _playerRepo.Create(newPlayer);
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index","Home");
        }
        public IActionResult ReadAll()
        {
            return View(_playerRepo.GetAll());
        }
    }
}
