using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TraderSellManager : ITraderSellService
    {
        ITraderSellDal _traderSellDal;
        public TraderSellManager(ITraderSellDal traderSellDal)
        {
            _traderSellDal = traderSellDal;
        }
        public void TAdd(TraderSell t)
        {
            _traderSellDal.Insert(t);
        }

        public void TDelete(TraderSell t)
        {
            _traderSellDal.Delete(t);
        }

        public TraderSell TGetByID(int id)
        {
            return _traderSellDal.GetByID(id);
        }

        public List<TraderSell> TGetList()
        {
            return _traderSellDal.GetList();
        }

        public void TUpdate(TraderSell t)
        {
            _traderSellDal.Update(t);
        }
    }
}

