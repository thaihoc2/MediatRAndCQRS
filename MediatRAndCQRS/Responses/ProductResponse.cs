using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRAndCQRS.Responses
{
    public class ProductResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
