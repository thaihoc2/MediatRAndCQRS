using MediatR;
using MediatRAndCQRS.Responses;

namespace MediatRAndCQRS.Command
{
    public class CreateProductCommand : IRequest<ProductResponse>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
