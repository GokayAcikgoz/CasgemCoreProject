using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pizzapan.EntityLayer.Concrete;
using Pizzapan.PresentationLayer.Models;
using System.Threading.Tasks;

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
        public async Task<IActionResult> Index(string id)
        {
            var appUser = await _userManager.FindByIdAsync(id);

            if (appUser != null && appUser.ConfirmCode == appUser.ConfirmCode)
            {
                
                appUser.EmailConfirmed = true;
                await _userManager.UpdateAsync(appUser);

                return RedirectToAction("Index", "Login");
            }

            return View();
        }
    }
}
