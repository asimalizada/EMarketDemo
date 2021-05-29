using System;
using Core.Entities.Abstract;

namespace EMarketDemo.Entities.Dtos
{
    public class ProductDetailsDto : IDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Obsolete : Attribute
    {
        private string a;
        public Obsolete(string a)
        {
            this.a = a;
        }


    }

}
