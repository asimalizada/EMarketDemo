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
        List<Product> GetByProductName(string productName);
        List<Product> GetByCategory(int categoryId);
        List<Product> GetByPrice(decimal min, decimal max);
        decimal GetMinPrice();
        decimal GetMaxPrice();
    }
}
