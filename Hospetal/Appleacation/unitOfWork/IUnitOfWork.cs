using Appleacation.readOnlyRepo;
using Appleacation.repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appleacation.unitOfWork
{
    public interface IUnitOfWork<T>:IDisposable where T:class
    {
        public IReposotory<T> Reposotory { get;  set; }
        public IReadOnlyReposotory<T> ReadOnlyReposotory { get;  set; }
        public Task<int> SaveAsync();
        public Task RollBackAsync();
        

    }
}
