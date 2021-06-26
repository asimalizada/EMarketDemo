using System;
using System.Collections.Generic;
using System.Linq;
using Core.Aspects.Postsharp.Caching;
using Core.Aspects.Postsharp.Logging;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using EMarketDemo.Business.Abstract;
using EMarketDemo.Business.CrossCuttingConcerns.Validation.FluentValidation;
using EMarketDemo.DataAccess.Abstract;
using EMarketDemo.Entities.Concrete;
using EMarketDemo.Entities.Dtos;
using FluentValidation;
using Core.Aspects.Postsharp.Transaction;
using Core.Aspects.Postsharp.Validation;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;

namespace EMarketDemo.Business.Concrete
{
    public class ProductManager : IProductService // N-layered project
    {
        private IProductDal _productDal; // Inversion  of Control  IoC
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [ValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Add(Product product)
        {
            // ...
            _productDal.Add(product);
        }
        
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(ProductValidator))]
        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager), "Get")]
        //  [LogAspect(typeof(DatabaseLogger))]
        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public Product GetById(int id)
        {
            return _productDal.Get(p => p.Id == id);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Product> GetByProductName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName
                .ToLower().Contains(productName.ToLower()));
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetAll
                (p => p.CategoryId == categoryId);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Product> GetByPrice(decimal min, decimal max)
        {
            return _productDal.GetAll
                (p => p.Price >= min & p.Price <= max);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public decimal GetMinPrice()
        {
            return _productDal.GetAll().Select(p => p.Price).Min();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public decimal GetMaxPrice()
        {
            return _productDal.GetAll().Select(p => p.Price).Max();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<ProductDetailsDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }

        [TransactionAspect]
        public void TransactionalMethod(Product product1, Product product2)
        {
            _productDal.Delete(product1);
            //....
            _productDal.Add(product1);
            // ...
            _productDal.Delete(product2);
            _productDal.Add(product2);
        }
    }
}
