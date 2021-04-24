using Core.Entities.Abstract;

namespace EMarketDemo.Entities.Concrete
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
