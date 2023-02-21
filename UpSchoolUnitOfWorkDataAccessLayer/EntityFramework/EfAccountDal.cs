using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchoolUnitOfWork_DataAccessLayer.Abstract;
using UpSchoolUnitOfWork_DataAccessLayer.Concrete;
using UpSchoolUnitOfWork_DataAccessLayer.Repository;
using UpSchoolUnitOfWork_EntityLayer.Concrete;

namespace UpSchoolUnitOfWork_DataAccessLayer.EntityFramework
{
    public class EfAccountDal : GenericRepository<Account>, IAccountDal
    {
        public EfAccountDal(Context context) : base(context)
        {
        }
    }
}
