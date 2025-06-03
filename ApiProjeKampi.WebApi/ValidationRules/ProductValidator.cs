using ApiProjeKampi.WebApi.Entities;
using FluentValidation;

namespace ApiProjeKampi.WebApi.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün Adı Boş Geçilemez ...");
            RuleFor(x => x.ProductName).MinimumLength(3).WithMessage("Ürün Adı En Az 3 Karakter Olmalıdır ...");
            RuleFor(x => x.ProductName).MaximumLength(50).WithMessage("Ürün Adı En Fazla 50 Karakter Olmalıdır ...");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün Fiyatı Boş Geçilemez ...").GreaterThan(0).WithMessage("Ürün Fiyatı Negatif Olamaz").LessThan(1000).WithMessage("Ürün Fiyatı bu kadar yüksek olamaz, girdiğiniz fiyatı kontrol ediniz..");

            RuleFor(x => x.ProductDescription).NotEmpty().WithMessage("Ürün Açıklaması Boş Geçilemez ...");
        }
    }
}
