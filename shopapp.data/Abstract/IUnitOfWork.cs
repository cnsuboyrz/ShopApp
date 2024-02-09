using System;

namespace shopapp.data.Abstract
{
    public interface IUnitOfWork: IDisposable
    {
         ICartRepository Carts {get;}
         ICategoryRepository Categories {get;}
         IOrderRepository Orders {get;}
         IProductRepository Products {get;} 

         IMainCategoryRepository MainCategories { get;}
         void Save();

    }
}