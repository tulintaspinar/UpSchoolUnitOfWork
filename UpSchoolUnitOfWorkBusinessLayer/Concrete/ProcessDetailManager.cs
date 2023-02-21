using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchoolUnitOfWork_BusinessLayer.Abstract;
using UpSchoolUnitOfWork_DataAccessLayer.Abstract;
using UpSchoolUnitOfWork_DataAccessLayer.UoW;
using UpSchoolUnitOfWork_EntityLayer.Concrete;

namespace UpSchoolUnitOfWork_BusinessLayer.Concrete
{
    public class ProcessDetailManager : IProcessDetailService
    {
        private readonly IProcessDetailDal _processDetailDal;
        private readonly IUoW _uoW;

        public ProcessDetailManager(IProcessDetailDal processDetailDal, IUoW uoW)
        {
            _processDetailDal = processDetailDal;
            _uoW = uoW;
        }

        public void TDelete(ProcessDetail t)
        {
            _processDetailDal.Delete(t);
            _uoW.Save();
        }

        public ProcessDetail TGetByID(int id)
        {
            return _processDetailDal.GetByID(id);
        }

        public List<ProcessDetail> TGetList()
        {
            return _processDetailDal.GetList();
        }

        public void TInsert(ProcessDetail t)
        {
            _processDetailDal.Insert(t);
            _uoW.Save();
        }

        public void TMultiUpdate(List<ProcessDetail> t)
        {
            _processDetailDal.MultiUpdate(t);
            _uoW.Save();
        }

        public void TUpdate(ProcessDetail t)
        {
            _processDetailDal.Update(t);
            _uoW.Save();
        }
    }
}
