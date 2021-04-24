using Core.DataAccess.Abstract;
using EMarketDemo.Entities.Concrete;

namespace EMarketDemo.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
