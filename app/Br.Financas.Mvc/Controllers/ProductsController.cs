using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Br.Financas.Application;
using Br.Financas.Domain.Interfaces;
using Br.Financas.Domain.Entities;

namespace Br.Financas.Mvc.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductApplication _productApplication;

        public ProductsController(ProductApplication produtctApplication)
        {
            _productApplication = produtctApplication;
        }

        public ActionResult Index()
        {
            var products = _productApplication.Get();
            return View(products);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _productApplication.Register(product);
                return RedirectToAction("index");
            }
            else
            {
                return View(product);
            }
        }
    }
}