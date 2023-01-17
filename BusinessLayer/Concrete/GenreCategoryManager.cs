using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GenreCategoryManager : IGenreCategoryService
    {
        IGenreCategoryDal _genreCategoryDal;
        public GenreCategoryManager(IGenreCategoryDal genreCategoryDal)
        {
            _genreCategoryDal = genreCategoryDal;
        }


        public void TAdd(GenreCategory t)
        {
            _genreCategoryDal.Insert(t);
        }

        public void TDelete(GenreCategory t)
        {
            _genreCategoryDal.Delete(t);
        }

        public GenreCategory TGetByID(int id)
        {
            return _genreCategoryDal.GetByID(id);
        }

        public List<GenreCategory> TGetList()
        {
            return _genreCategoryDal.GetList();
        }
        public List<GenreCategory> GetGenreCategoryListWithSub()
        {
            return _genreCategoryDal.GenreCategoriesListBySub();
        }

        public List<GenreCategory> TGetList(int id)
        {
            return _genreCategoryDal.GetList(x => x.SubCategoryID == id);
        }

        public void TUpdate(GenreCategory t)
        {
            _genreCategoryDal.Update(t);
        }
    }
}
