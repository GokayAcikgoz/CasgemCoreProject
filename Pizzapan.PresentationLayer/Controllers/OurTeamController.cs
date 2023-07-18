using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.BusinessLayer.ValidationRules.OurTeamValidatior;
using Pizzapan.EntityLayer.Concrete;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class OurTeamController : Controller
    {
        private readonly IOurTeamService _ourTeamService;

        public OurTeamController(IOurTeamService ourTeamService)
        {
            _ourTeamService = ourTeamService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddOurTeam()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddOurTeam(OurTeam ourTeam)
        {
            CreateOurTeamValidator createOurTeamValidator = new CreateOurTeamValidator();
            ValidationResult result = createOurTeamValidator.Validate(ourTeam);
            if(result.IsValid)
            {
                _ourTeamService.TInsret(ourTeam);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
