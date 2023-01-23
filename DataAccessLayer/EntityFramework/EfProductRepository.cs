using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductRepository : GenericRepository<Product>, IProductDal
    {
        public List<Product> ProductListBuyTraderId()
        {
            using (var c = new Context())
            {
                return c.Products.Include(x => x.BuyTrader).ToList();
            }
        }

        public List<Product> ProductListBySub()
        {
            using (var c = new Context())
            {
                return c.Products.Include(x => x.GenreCategory).ToList();
            }
        }

        public List<Product> ProductListSellTraderId()
        {
            using (var c = new Context())
            {
                return c.Products.Include(x => x.SellTrader).ToList();
            }
        }
    }
}
