using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatRAndCQRS.Models;

namespace MediatRAndCQRS.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> products = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Name = "Iphone X",
                Description = "This is an iphone"
            },
            new Product()
            {
                Id = 2,
                Name = "Iphone XS Max",
                Description = "This is an iphone"
            },
            new Product()
            {
                Id = 3,
                Name = "Iphone Pro",
                Description = "This is an iphone"
            },
            new Product()
            {
                Id = 4,
                Name = "Samsung S10",
                Description = "This is a stupid phone"
            }
        };

        public Task<Product> CreateProductAsync(Product product)
        {
            products.Add(product);
            return Task.FromResult(product);
        }

        public Task<List<Product>> GetAllProductsAsync()
        {
            return Task.FromResult(products);
        }

        public Task<Product> GetById(int productId)
        {
            return Task.FromResult(products.FirstOrDefault(x => x.Id == productId));
        }
    }
}
