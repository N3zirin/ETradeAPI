using ETradeAPI.Application.Abstractions;
using ETradeAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts() => new() //target type collection
        {
            new() { Id = Guid.NewGuid(), Name = "Product 1", Stock = 23, Price = 21.3m },
            new() { Id = Guid.NewGuid(), Name = "Product 2", Stock = 24, Price = 13.2m },
            new() { Id = Guid.NewGuid(), Name = "Product 3", Stock = 12, Price = 22.7m },
            new() { Id = Guid.NewGuid(), Name = "Product 4", Stock = 10, Price = 20.8m },
            new() { Id = Guid.NewGuid(), Name = "Product 5", Stock = 19, Price = 13.6m }
        };
    }
}
