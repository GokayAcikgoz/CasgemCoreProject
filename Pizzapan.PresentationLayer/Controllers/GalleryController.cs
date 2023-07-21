using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;
using Pizzapan.PresentationLayer.Models;
using System.IO;
using System;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class GalleryController : Controller
    {
        private readonly IGalleryService _galleryService;

        public GalleryController(IGalleryService galleryService)
        {
            _galleryService = galleryService;
        }

        public IActionResult Index()
        {
            var values = _galleryService.TGetList();
            return View(values);
        }

        public IActionResult DeleteGallery(int id)
        {
            var value = _galleryService.TGetById(id);
            _galleryService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddGallery()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGallery(GalleryViewModel model)
        {
            var resource = Directory.GetCurrentDirectory();
            var extension = Path.GetExtension(model.Image.FileName);
            var imageName = Guid.NewGuid() + extension; //guid benzersiz 32 hanelik bir isim
            var saveLocation = resource + "/wwwroot/images/" + imageName;
            var stream = new FileStream(saveLocation, FileMode.Create);
            model.Image.CopyTo(stream);
            Gallery gallery = new Gallery();
            gallery.Title = model.Title;
            gallery.ImageUrl = imageName;
            _galleryService.TInsret(gallery);

            return RedirectToAction("Index");
        }
    }
}
