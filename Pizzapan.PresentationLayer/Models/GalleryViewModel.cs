using Microsoft.AspNetCore.Http;

namespace Pizzapan.PresentationLayer.Models
{
    public class GalleryViewModel
    {
        public IFormFile Image { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
    }
}
