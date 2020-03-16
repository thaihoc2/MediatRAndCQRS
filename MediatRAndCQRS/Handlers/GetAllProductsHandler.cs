using MediatR;
using MediatRAndCQRS.Queries;
using MediatRAndCQRS.Repositories;
using MediatRAndCQRS.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRAndCQRS.Handlers
{
    public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, List<ProductResponse>>
    {
        private IProductRepository _productRepository;

        public GetAllProductsHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<List<ProductResponse>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetAllProductsAsync();

            // mapping data
            return products.Select(x => new ProductResponse()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description
            }).ToList();
        }
    }
}
