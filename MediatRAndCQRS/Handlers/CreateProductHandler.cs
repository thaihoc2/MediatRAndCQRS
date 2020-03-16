using MediatR;
using MediatRAndCQRS.Command;
using MediatRAndCQRS.Repositories;
using MediatRAndCQRS.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRAndCQRS.Handlers
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, ProductResponse>
    {
        private IProductRepository _productRepository;

        public CreateProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var response = await _productRepository.CreateProductAsync(new Models.Product() { Id = 5, Name = request.Name, Description = request.Description });
            return new ProductResponse() { Id = response.Id, Name = response.Name, Description = response.Description };
        }
    }
}
