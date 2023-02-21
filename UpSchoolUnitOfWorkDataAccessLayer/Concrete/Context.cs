using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchoolUnitOfWork_EntityLayer.Concrete;

namespace UpSchoolUnitOfWork_DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-5CE3LGO;Initial Catalog=UpSchoolUnitOfWork;Integrated Security=True;"); 
        }
        public DbSet<Account> Accounts { get; set; } 
        public DbSet<ProcessDetail> ProcessDetails { get; set; } 
    }
}
