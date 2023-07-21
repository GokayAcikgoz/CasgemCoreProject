using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;

namespace Pizzapan.PresentationLayer.ViewComponents.Contact
{
    public class _MessagePartial : ViewComponent
    {
        private readonly IContactUsService _contactUsService;
        private readonly IContactService _contactService;

        public _MessagePartial(IContactUsService contactUsService, IContactService contactService)
        {
            _contactUsService = contactUsService;
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _contactUsService.TGetById(1);            

            ViewBag.address = value.Address;
            ViewBag.phone = value.Phone;
            ViewBag.date = value.StartEndDate;
            ViewBag.mail = value.Mail;
            
            return View("Message");
        }

        
    }
}
