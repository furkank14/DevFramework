using System;
using AutoMapper;
using DevFramework.Northwind.Business.Concrete.Managers;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.Concrete;
using FluentValidation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DevFramework.Northwind.Business.Tests
{
    [TestClass]
    public class ProductManagerTest
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void product_validation_check()
        {
            Mock<IProductDal> mock = new Mock<IProductDal>();
            Mock<IMapper> mock2 = new Mock<IMapper>();
            ProductManager productManager = new ProductManager(mock.Object,mock2.Object);

            productManager.Add(new Product());
        }
    }
}
