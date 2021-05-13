using EMarketDemo.Entities.Concrete;
using FluentValidation;

namespace EMarketDemo.Business.CrossCuttingConcerns.Validation.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.ProductName).Must(IsStartWith)
                .WithMessage("Product name must be start with upper case letter!");

            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.CategoryId).GreaterThan(0);

            RuleFor(p => p.Price).NotEmpty();
            RuleFor(p => p.Price).GreaterThan(0);

            RuleFor(p => p.UnitsInStock).NotEmpty();
            RuleFor(p => p.UnitsInStock).GreaterThan(0);

        }

        private bool IsStartWith(string productName)
        {
            if (productName[0].ToString() == productName[0].ToString().ToUpper()) return true;
            return false;
            //if (productName[0] >= 65 && productName[0] <= 90) return true;
        }
    }
}
