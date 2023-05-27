using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProcessManager : IProcessService
    {
        private readonly IProcessDal _processDall;
        private readonly IUowDal _uowDal;

        public ProcessManager(IProcessDal processDall, IUowDal uowDal)
        {
            _processDall = processDall;
            _uowDal = uowDal;
        }

        public void TDelete(Process t)
        {
            _processDall.Delete(t);
            _uowDal.Save();
        }

        public Process TGetByID(int id)
        {
            return _processDall.GetByID(id);
        }

        public List<Process> TGetList()
        {
            return _processDall.GetList();
        }

        public void TInsert(Process t)
        {
            _processDall.Insert(t);
            _uowDal.Save();
        }

        public void TMultiUpdate(List<Process> t)
        {
            _processDall.MultiUpdate(t);
            _uowDal.Save();
        }

        public void TUpdate(Process t)
        {
            _processDall.Update(t);
            _uowDal.Save();
        }
    }
}
