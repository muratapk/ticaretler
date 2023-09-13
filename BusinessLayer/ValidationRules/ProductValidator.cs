using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator() {
            RuleFor(x => x.ProductCode).NotEmpty().WithMessage("Ürün Kodu Boş Geçilemez");
            RuleFor(x=>x.ProductPrice).NotEmpty().WithMessage("Ürün Fiyatı Boş Geçilemez");
            RuleFor(x => x.ProductPrice).LessThan(0).WithMessage("Ürün Değeri Sıfırdan az Olamaz");


        }

    }
}
