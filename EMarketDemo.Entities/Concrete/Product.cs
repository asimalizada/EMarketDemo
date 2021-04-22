using Core.Entities.Abstract;

namespace EMarketDemo.Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }
    }
}
