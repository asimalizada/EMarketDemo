using EMarketDemo.Entities.Concrete;
using System.Collections.Generic;

namespace EMarketDemo.Business.Abstract
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
        List<Category> GetAll();
        Category GetById(int id);
    }
}
