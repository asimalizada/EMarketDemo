using Core.DataAccess.Concrete.EntityFramework;
using EMarketDemo.DataAccess.Abstract;
using EMarketDemo.Entities.Concrete;

namespace EMarketDemo.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, EMarketContext>, IProductDal
    {
    }
}
