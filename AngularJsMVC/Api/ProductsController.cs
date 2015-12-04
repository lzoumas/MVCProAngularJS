using AngularJsMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AngularJsMVC.WebApi
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Kayak", Description = "A boat for one person", Category = "Watersports", Price = 275 },
            new Product { Id = 2, Name = "Lifejacket", Description = "Protective and fashionable", Category = "Watersports", Price = 48.95M },
            new Product { Id = 3, Name = "Soccer Ball", Description = "FIFA-approved size and weight", Category = "Soccer", Price = 19.5M },
            new Product { Id = 4, Name = "Corner Flags", Description = "Give your playing field a professional touch", Category = "Soccer", Price = 34.95M },
            new Product { Id = 5, Name = "Stadium", Description = "Flat-packed 35,000-seat stadium", Category = "Soccer", Price = 79500 },
            new Product { Id = 6, Name = "Thinking Cap", Description = "Improve your brain efficiency by 75%", Category = "Chess", Price = 16 },
            new Product { Id = 7, Name = "Unsteady Chair", Description = "Secretly give your opponent a disadvantage", Category = "Chess", Price = 29.95M },
            new Product { Id = 8, Name = "Human Chess Board", Description = "A fun game for the family", Category = "Chess", Price = 75 },
            new Product { Id = 9, Name = "Bling-Bling King", Description = "Gold-plated, diamond-studded King", Category = "Chess", Price = 1200 }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
