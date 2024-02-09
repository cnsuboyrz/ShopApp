using Microsoft.EntityFrameworkCore;
using shopapp.data.Abstract;
using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shopapp.data.Concrete.EfCore
{
    public class EfCoreMainCategoryRepository : EfCoreGenericRepository<MainCategory>, IMainCategoryRepository
    {
        public EfCoreMainCategoryRepository(ShopContext context) : base(context)
        {

        }

        private ShopContext ShopContext
        {
            get { return context as ShopContext; }
        }
        public void DeleteFromMainCategory(int categoryId, int maincategoryId)
        {
            var cmd = "delete from categories where CategoryId=@p0 and MainCategoryId=@p1";
            ShopContext.Database.ExecuteSqlRaw(cmd, categoryId, maincategoryId);
        }

       
        public MainCategory GetByIdWithCategory(int maincategoryid)
        {
            return ShopContext.MainCategories
                .Where(mc => mc.MainCategoryId == maincategoryid)
                .Include(mc => mc.Categories) // MainCategory'nin Categories ilişkisini yükler
                .FirstOrDefault();
        }

       
    }
}
