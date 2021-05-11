using EMarketDemo.Business.Abstract;
using EMarketDemo.Business.Concrete;
using EMarketDemo.DataAccess.Abstract;
using EMarketDemo.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace EMarketDemo.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();

        }
    }
}
