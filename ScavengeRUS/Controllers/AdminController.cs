using Microsoft.AspNetCore.Mvc;
using ScavengeRUS.Models.Entities;
using ScavengeRUS.Services;

namespace ScavengeRUS.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminRepository _adminRepo;

        public AdminController(IAdminRepository adminRepo)
        {
            _adminRepo = adminRepo;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Admin newAdmin)
        {
            if (ModelState.IsValid)
            {
                await _adminRepo.Create(newAdmin);
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult ReadAll()
        {
            return View(_adminRepo.GetAll());
        }
    }
}
