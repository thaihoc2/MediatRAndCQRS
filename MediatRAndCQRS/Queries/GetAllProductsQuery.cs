using MediatR;
using MediatRAndCQRS.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRAndCQRS.Queries
{
    public class GetAllProductsQuery : IRequest<List<ProductResponse>>
    {
    }
}
