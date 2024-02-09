using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.data.Abstract
{
    public interface IMainCategoryRepository : IRepository<MainCategory>
    {
        MainCategory GetByIdWithCategory(int maincategoryid);

        void DeleteFromMainCategory(int categoryId, int maincategoryId);
    }
}
