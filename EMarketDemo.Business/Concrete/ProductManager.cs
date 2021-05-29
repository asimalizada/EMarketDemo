using System;
using System.Collections.Generic;
using System.Linq;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using EMarketDemo.Business.Abstract;
using EMarketDemo.Business.CrossCuttingConcerns.Validation.FluentValidation;
using EMarketDemo.DataAccess.Abstract;
using EMarketDemo.Entities.Concrete;
using EMarketDemo.Entities.Dtos;
using FluentValidation;
using Core.Aspects.Postsharp.Transaction;
using Core.Aspects.Postsharp.Validation;

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
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        [ValidationAspect(typeof(ProductValidator))]
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
            return _productDal.Get(p => p.Id == id);
        }

        public List<Product> GetByProductName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName
                .ToLower().Contains(productName.ToLower()));
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetAll
                (p => p.CategoryId == categoryId);
        }

        public List<Product> GetByPrice(decimal min, decimal max)
        {
            return _productDal.GetAll
                (p => p.Price >= min & p.Price <= max);
        }

        public decimal GetMinPrice()
        {
            return _productDal.GetAll().Select(p => p.Price).Min();
        }

        public decimal GetMaxPrice()
        {
            return _productDal.GetAll().Select(p => p.Price).Max();
        }

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
