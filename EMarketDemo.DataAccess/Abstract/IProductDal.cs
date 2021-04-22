using Core.DataAccess.Abstract;
using EMarketDemo.Entities.Concrete;

namespace EMarketDemo.DataAccess.Abstract
{
    // CRUD -> Create-Read-Update-Delete
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
