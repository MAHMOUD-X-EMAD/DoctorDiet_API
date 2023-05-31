using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        void SaveChanges();
        void CommitChanges();
        void BeginTransaction();
    }
}
