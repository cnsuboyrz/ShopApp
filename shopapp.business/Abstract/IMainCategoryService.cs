using System;
using System.Collections.Generic;
using System.Text;
using shopapp.entity;
namespace shopapp.business.Abstract
{
    public interface IMainCategoryService : IValidator<MainCategory>
    {
        MainCategory GetById(int id);

        MainCategory GetByIdWithCategory(int maincategoryid);

        List<MainCategory> GetAll();

        void Create(MainCategory entity);

        void Update(MainCategory entity);
        void Delete(MainCategory entity);
        void DeleteFromMainCategory(int categoryId ,int maincategoryid);
    }
}
