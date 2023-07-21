using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;

namespace Pizzapan.PresentationLayer.ViewComponents.Default
{
    public class _SocialMedia : ViewComponent
    {
        private readonly ISocialMediService _socialMediaService;

        public _SocialMedia(ISocialMediService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _socialMediaService.TGetList();
            return View(values);
        }
    }
}
