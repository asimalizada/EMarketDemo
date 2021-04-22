using System.Collections.Generic;
using EMarketDemo.Entities.Concrete;

namespace EMarketDemo.Business.Abstract
{
    public interface IProductService
    {   // UI -> User Interface | Web Api 
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetAll();
        Product GetById(int id);
    }
}
