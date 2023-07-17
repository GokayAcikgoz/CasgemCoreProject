using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pizzapan.EntityLayer.Concrete;
using Pizzapan.PresentationLayer.Models;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class ConfirmedMailController : Controller
    {

        private readonly UserManager<AppUser> _userManager;

        public ConfirmedMailController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string id)
        {
            var appUser = _userManager.FindByIdAsync(id).Result;

            if (appUser != null && appUser.ConfirmCode == appUser.ConfirmCode)
            {
                
                appUser.EmailConfirmed = true;
                _userManager.UpdateAsync(appUser).Wait();

                return RedirectToAction("Index", "Login");
            }

            return View();
        }
    }
}
