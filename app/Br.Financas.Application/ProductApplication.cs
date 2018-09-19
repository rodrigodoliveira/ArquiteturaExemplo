using Br.Financas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Br.Financas.Domain.Interfaces;

namespace Br.Financas.Application
{
    public class ProductApplication : ApplicationBase
    {
        private IProductRepository _productRepository;

        public ProductApplication(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Register(Product product)
        {
            BeginTransaction();

            _productRepository.Add(product);

            Commit();

        }

        public IEnumerable<Product> Get()
        {
            return _productRepository.Get();
        }
    }
}
