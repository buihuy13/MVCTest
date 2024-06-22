using MVCTest.Models;

namespace MVCTest.Services
{
    public class ProductService : List<Product>
    {
        public ProductService()
        {
            this.AddRange(new Product[]
            {
                new Product() {Id = 1, Name = "Iphone", Price = 1000},
                new Product() {Id = 2, Name = "Ipad", Price = 8000},
                new Product() {Id = 3, Name = "Nokia", Price = 300},
                new Product() {Id = 4, Name = "Samsung", Price = 500},
            }); 
        }
    }
}
