using MediatRAndCQRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRAndCQRS.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProductsAsync();

        Task<Product> CreateProductAsync(Product product);
        Task<Product> GetById(int productId);
    }
}
