using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Entities.Concrete;

namespace DevFramework.Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            var model = new ProductListViewModel
            {
                Products = _productService.GetAll()
            };
            return View(model);
        }

        public string Add()
        {
            _productService.Add(new Product
            {
                ProductName = "Pc1",
                CategoryId = 5,
                UnitPrice = 10,
                QuantityPerUnit = "dedede"
            });
            return "Added";
        }

        public string AddUpdate()
        {
            _productService.TransactionalOperation(new Product
            {
                ProductName = "Pc2",
                CategoryId = 5,
                UnitPrice = 10,
                QuantityPerUnit = "dedede"
            }, new Product
            {
                ProductName = "Pc4",
                CategoryId = 5,
                UnitPrice = 1,
                QuantityPerUnit = "dedede",
                ProductId = 81
            });
            return "update";
        }
    }
}