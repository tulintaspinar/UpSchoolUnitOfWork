using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchoolUnitOfWork_DataAccessLayer.Concrete;

namespace UpSchoolUnitOfWork_DataAccessLayer.UoW
{
    public class UoW : IUoW
    {
        private readonly Context _context;

        public UoW(Context context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
