using Microsoft.AspNetCore.Mvc;
using ScavengeRUS.Models.Entities;
using ScavengeRUS.Services;

namespace ScavengeRUS.Controllers
{
    public class HuntController : Controller
    {
        private readonly IHuntRepository _huntRepo;

        public HuntController(IHuntRepository huntRepo)
        {
            _huntRepo = huntRepo;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Hunt newHunt)
        {
            if (ModelState.IsValid)
            {
                await _huntRepo.Create(newHunt);
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult ReadAll()
        {
            return View(_huntRepo.GetAll());
        }
    }
}
