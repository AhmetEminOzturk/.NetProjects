using Api.BusinessLayer.Abstract;
using Api.DataAccessLayer.Abstract;
using Api.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.BusinessLayer.Concrete
{
    public class BalanceManager : IBalanceService
    {
        private readonly IBalanceDal _balanceDal;

        public BalanceManager(IBalanceDal balanceDal)
        {
            _balanceDal = balanceDal;
        }

        public void TDelete(Balance t)
        {
            _balanceDal.Delete(t);
        }

        public Balance TGetById(int id)
        {
            return _balanceDal.GetById(id);
        }

        public List<Balance> TGetList()
        {
            return _balanceDal.GetList();
        }

        public void TInsert(Balance t)
        {
           _balanceDal.Insert(t);
        }

        public void TUpdate(Balance t)
        {
            _balanceDal.Update(t);
        }
    }
}
