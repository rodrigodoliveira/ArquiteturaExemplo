using Br.Financas.Application;
using Br.Financas.Domain.Entities;
using Br.Financas.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Br.Financas.UI.Api.Controllers {

    public class ProductsController : ApiController {

        private ProductApplication _productApplication;
        private IProductRepository _productRepository;

        public ProductsController(ProductApplication productApplication, IProductRepository productRepository)
        {
            _productApplication = productApplication;
            _productRepository = productRepository;
        }



        [HttpGet]
        public IHttpActionResult Get()
        {
            IDependencyResolver
            var products = _productRepository.Get();
            return Json(products);
        }
    }
}
