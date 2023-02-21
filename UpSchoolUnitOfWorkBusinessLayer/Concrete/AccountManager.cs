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
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountDal;
        private readonly IUoW _uoW;

        public AccountManager(IAccountDal accountDal, IUoW uoW)
        {
            _accountDal = accountDal;
            _uoW = uoW;
        }

        public void TDelete(Account t)
        {
            _accountDal.Delete(t);
            _uoW.Save();
        }

        public Account TGetByID(int id)
        {
            return _accountDal.GetByID(id);
        }

        public List<Account> TGetList()
        {
            return _accountDal.GetList();
        }

        public void TInsert(Account t)
        {
            _accountDal.Insert(t);
            _uoW.Save();
        }

        public void TMultiUpdate(List<Account> t)
        {
            _accountDal.MultiUpdate(t);
            _uoW.Save();
        }

        public void TUpdate(Account t)
        {
            _accountDal.Update(t);
            _uoW.Save();
        }
    }
}
