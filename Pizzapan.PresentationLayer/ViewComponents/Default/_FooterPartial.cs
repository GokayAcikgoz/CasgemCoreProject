using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;

namespace Pizzapan.PresentationLayer.ViewComponents.Default
{
    public class _FooterPartial : ViewComponent
    {
        private readonly IContactUsService _contactUsService;

        public _FooterPartial(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _contactUsService.TGetById(1);

            ViewBag.title = value.Title;
            ViewBag.address = value.Address;
            ViewBag.phone = value.Phone;
            ViewBag.mail = value.Mail;
            ViewBag.date = value.StartEndDate;
            return View();
        }
    }
}
