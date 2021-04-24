using System;
using System.Collections.Generic;
using EMarketDemo.Business.Abstract;
using EMarketDemo.DataAccess.Abstract;
using EMarketDemo.Entities.Concrete;

namespace EMarketDemo.Business.Concrete
{
    public class ProductManager : IProductService // N-layered project
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p=>p.Id == id);
        }
    }
}
