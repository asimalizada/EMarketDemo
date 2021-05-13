using System.Collections.Generic;
using Core.DataAccess.Abstract;
using EMarketDemo.Entities.Concrete;
using EMarketDemo.Entities.Dtos;

namespace EMarketDemo.DataAccess.Abstract
{
    // CRUD -> Create-Read-Update-Delete
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailsDto> GetProductDetails();
    }
}
