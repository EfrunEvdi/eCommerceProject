using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MainCategoryManager : IMainCategoryService
    {
        IMainCategoryDal _mainCategoryDal;
        public MainCategoryManager(IMainCategoryDal mainCategoryDal)
        {
            _mainCategoryDal = mainCategoryDal;
        }
        public void TAdd(MainCategory t)
        {
            _mainCategoryDal.Insert(t);
        }

        public void TDelete(MainCategory t)
        {
            _mainCategoryDal.Delete(t);
        }

        public MainCategory TGetByID(int id)
        {
            return _mainCategoryDal.GetByID(id);
        }

        public List<MainCategory> TGetList()
        {
            return _mainCategoryDal.GetList();
        }

       

        public List<MainCategory> TGetList(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(MainCategory t)
        {
            _mainCategoryDal.Update(t);
        }
    }
}

