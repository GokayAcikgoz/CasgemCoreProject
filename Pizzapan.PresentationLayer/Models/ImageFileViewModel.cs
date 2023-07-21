using Microsoft.AspNetCore.Http;
using Pizzapan.EntityLayer.Concrete;

namespace Pizzapan.PresentationLayer.Models
{
    public class ImageFileViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile Image { get; set; }
        public int CategoryID { get; set; }
    
        

    }
}
