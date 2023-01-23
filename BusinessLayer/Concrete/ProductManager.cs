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
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void TAdd(Product t)
        {
            _productDal.Insert(t);
        }

        public void TDelete(Product t)
        {
            _productDal.Delete(t);
        }

        public Product TGetByID(int id)
        {
            return _productDal.GetByID(id);
        }

        public List<Product> TGetList()
        {
            return _productDal.GetList();
        }

        public List<Product> TGetList(int id)
        {
            return _productDal.GetList(x => x.ProductID == id);
        }
        public List<Product> GetProductWithBuyTraderID(int id)
        {
            return _productDal.GetList(x => x.BuyTraderID == id);
        }
        public List<Product> GetProductWithSellTraderID(int id)
        {
            return _productDal.GetList(x => x.SellTraderID == id);
        }
        public List<Product> GetProductByGenre(int id)
        {
            return _productDal.GetList(x => x.GenreCategory.SubCategoryID == id);
        }

        public List<Product> GetProductListWithSub()
        {
            return _productDal.ProductListBySub();
        }
        //public List<Product> GetProductByTrader(int id)
        //{
        //    return _productDal.GetList(x => x.BuyTraderID == id);
        //}

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }
    }
}

