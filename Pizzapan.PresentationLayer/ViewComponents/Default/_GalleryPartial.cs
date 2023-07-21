using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;

namespace Pizzapan.PresentationLayer.ViewComponents.Default
{
    public class _GalleryPartial : ViewComponent
    {
        private readonly IGalleryService _galleryService;

        public _GalleryPartial(IGalleryService galleryService)
        {
            _galleryService = galleryService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _galleryService.TGetList();
            return View(values);
        }
    }
}
