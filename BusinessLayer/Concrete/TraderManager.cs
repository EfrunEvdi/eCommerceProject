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
    public class TraderManager : ITraderService
    {
        ITraderDal _traderDal;
        public TraderManager(ITraderDal traderDal)
        {
            _traderDal = traderDal;
        }
        public void TAdd(Trader t)
        {
            _traderDal.Insert(t);
        }

        public void TDelete(Trader t)
        {
            _traderDal.Delete(t);
        }

        public Trader TGetByID(int id)
        {
            return _traderDal.GetByID(id);
        }

        public List<Trader> TGetList()
        {
            return _traderDal.GetList();
        }

        public List<Trader> TGetList(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Trader t)
        {
            _traderDal.Update(t);
        }
    }
}

