using Microsoft.AspNetCore.Mvc;
using MVCTest.Services;

namespace MVCTest.Controllers
{
    public class FirstController : Controller
    {
        private readonly ProductService _productService;
        public FirstController(ProductService products) {
            _productService = products;
        }
        public string Index()
        {
            // this.HttpContext
            // this.Request
            // this.Response
            // this.RouteData
            
            // this.User
            // this.ModelState
            // this.ViewData
            // this.Url
            // this.TempData
            // ...
            return "This is first Controller";
        }
        
        public IActionResult BirdsImage()
        {
            var builder = WebApplication.CreateBuilder();
            string filepath = Path.Combine(builder.Environment.ContentRootPath, "Files", "Birds.jpg");

            var bytes = System.IO.File.ReadAllBytes(filepath);

            return File(bytes, "image/jpg");
        }

        public IActionResult HelloView(string userName)
        {
            if (string.IsNullOrEmpty(userName))
            {
                userName = "Customer";
            }

            return View((object)userName);
        }

        public IActionResult ViewProduct(int? id)
        {
            if (id==null)
            {
                return NotFound("Cannot Find Product");
            }
            var product = (from p in _productService
                           where p.Id == id
                           select p).FirstOrDefault(); 
            if (product == null)
            {
                return NotFound("Cannot Find Product");
            }

            return Content(product.ShowInfor());
        }
    }
}
