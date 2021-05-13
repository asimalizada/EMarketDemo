using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.Concrete.EntityFramework;
using EMarketDemo.DataAccess.Abstract;
using EMarketDemo.Entities.Concrete;
using EMarketDemo.Entities.Dtos;

namespace EMarketDemo.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, EMarketContext>, IProductDal
    {
        public List<ProductDetailsDto> GetProductDetails()
        {
            using (EMarketContext context = new EMarketContext())
            {
                var result = from p in context.Products
                    join c in context.Categories on p.CategoryId equals c.Id
                    select new ProductDetailsDto
                    {
                        Id = p.Id,
                        ProductName = p.ProductName,
                        Price = p.Price,
                        UnitsInStock = p.UnitsInStock,
                        CategoryName = c.Name
                    };
                return result.ToList();
            }
        }
    }
}
