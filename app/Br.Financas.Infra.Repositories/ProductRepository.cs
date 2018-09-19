using Br.Financas.Domain.Entities;
using Br.Financas.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Br.Financas.Infra.Repositories {
    public class ProductRepository : RepositoryBase<Product>, IProductRepository {

        public IEnumerable<Product> GetByPrice(decimal price)
        {
            return Context.Products.Where(x => x.Price == price).ToList();
        }
    }
}
