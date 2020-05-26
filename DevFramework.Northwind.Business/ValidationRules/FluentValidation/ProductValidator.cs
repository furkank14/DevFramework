using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Northwind.Entities.Concrete;
using FluentValidation;

namespace DevFramework.Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün İsmi Boş Olamaz");
            RuleFor(p => p.ProductName).Length(3, 20);
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.QuantityPerUnit).NotEmpty().When(p => p.ProductName != "Bos");
            RuleFor(p => p.UnitPrice).NotEmpty();

            RuleFor(p => p.UnitPrice).GreaterThan(0);

        }
    }
}
