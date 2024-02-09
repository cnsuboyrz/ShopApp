using shopapp.business.Abstract;
using shopapp.data.Abstract;
using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.business.Concrete
{
    public class MainCategoryManager : IMainCategoryService
    {
        private readonly IUnitOfWork _unitofwork;
        public MainCategoryManager(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        public string ErrorMessage { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Create(MainCategory entity)
        {
            _unitofwork.MainCategories.Create(entity);
            _unitofwork.Save();
        }

        public void Delete(MainCategory entity)
        {
            _unitofwork.MainCategories.Delete(entity);
            _unitofwork.Save();
        }

        public void DeleteFromMainCategory(int categoryId, int maincategoryid)
        {
            _unitofwork.MainCategories.DeleteFromMainCategory(categoryId, maincategoryid);
        }

        public List<MainCategory> GetAll()
        {
            return _unitofwork.MainCategories.GetAll();
        }

        public MainCategory GetById(int id)
        {
            return _unitofwork.MainCategories.GetById(id);
        }

        public MainCategory GetByIdWithCategory(int maincategoryid)
        {
            return _unitofwork.MainCategories.GetByIdWithCategory(maincategoryid);
        }


        public void Update(MainCategory entity)
        {
            _unitofwork.MainCategories.Update(entity);
            _unitofwork.Save();
        }

        public bool Validation(MainCategory entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
