using Microsoft.AspNetCore.Http;

namespace Pizzapan.PresentationLayer.Models
{
    public class TestimonialViewModel
    {
        public string CustomerName { get; set; }
        public string CustomerTitle { get; set; }
        public string Comment { get; set; }
        public IFormFile Image { get; set; }
        public string ImageUrl { get; set; }
    }
}
