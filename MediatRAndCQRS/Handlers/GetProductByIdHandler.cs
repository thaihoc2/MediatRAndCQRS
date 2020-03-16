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
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, ProductResponse>
    {
        private IProductRepository _productRepository;

        public GetProductByIdHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<ProductResponse> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetById(request.ProductId);

            // mapping data
            return new ProductResponse()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description
            };
        }
    }
}
