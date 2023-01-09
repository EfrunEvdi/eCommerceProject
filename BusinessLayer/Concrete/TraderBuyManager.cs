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
    public class TraderBuyManager : ITraderBuyService
    {
        ITraderBuyDal _traderBuyDal;
        public TraderBuyManager(ITraderBuyDal traderBuyDal)
        {
            _traderBuyDal = traderBuyDal;
        }
        public void TAdd(TraderBuy t)
        {
            _traderBuyDal.Insert(t);
        }

        public void TDelete(TraderBuy t)
        {
            _traderBuyDal.Delete(t);
        }

        public TraderBuy TGetByID(int id)
        {
            return _traderBuyDal.GetByID(id);
        }

        public List<TraderBuy> TGetList()
        {
            return _traderBuyDal.GetList();
        }

        public void TUpdate(TraderBuy t)
        {
            _traderBuyDal.Update(t);
        }
    }
}

