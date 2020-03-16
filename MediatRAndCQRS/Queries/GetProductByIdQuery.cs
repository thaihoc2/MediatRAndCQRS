using MediatR;
using MediatRAndCQRS.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRAndCQRS.Queries
{
    public class GetProductByIdQuery : IRequest<ProductResponse>
    {
        public GetProductByIdQuery(int productId)
        {
            this.ProductId = productId;
        }
        public int ProductId { get; set; }
    }
}
