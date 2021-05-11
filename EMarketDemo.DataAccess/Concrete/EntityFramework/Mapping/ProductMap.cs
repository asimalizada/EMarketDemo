using EMarketDemo.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace EMarketDemo.DataAccess.Concrete.EntityFramework.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("Products");
            HasKey(p => p.Id);

            Property(p => p.Price).HasColumnName("Price");
            Property(p => p.CategoryId).HasColumnName("CategoryId");
            Property(p => p.ProductName).HasColumnName("ProductName");
            Property(p => p.UnitsInStock).HasColumnName("UnitsInStock");
        }
    }
}
