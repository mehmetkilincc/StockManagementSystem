using StockManagementSystem.Business.Abstract;
using StockManagementSystem.Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using StockManagementSystem.DataAccess.Abstract;
using StockManagementSystem.DataAccess.Concrete;
using StockManagementSystem.Entities.Concrete;

namespace StockManagementSystem.Business.DependencySolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            //Admin Dependecy İnjection işlemleri
            Bind<IAdminService>().To<AdminManager>().InSingletonScope();
            Bind<IAdminDal>().To<AdminDal>().InSingletonScope();

            //Sale Dependency İnjection İşlemleri
            Bind<ISaleService>().To<SaleManager>().InSingletonScope();
            Bind<ISaleDal>().To<SaleDal>().InSingletonScope();

            //Category Dependecy İnjection İşlemleri
            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<CategoryDal>().InSingletonScope();

            //Brand Dependecy İnjection İşlemleri
            Bind<IBrandService>().To<BrandManager>().InSingletonScope();
            Bind<IBrandDal>().To<BrandDal>().InSingletonScope();

            //Customer Dependecy İnjection İşlemleri
            Bind<ICustomerService>().To<CustomerManager>().InSingletonScope();
            Bind<ICustomerDal>().To<CustomerDal>().InSingletonScope();

            //Product Dependecy İnjection İşlemleri
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<ProductDal>().InSingletonScope();

            //Cart Dependecy İnjection İşlemleri
            Bind<ICartService>().To<CartManager>().InSingletonScope();
            Bind<ICartDal>().To<CartDal>().InSingletonScope();

        }
    }
}
