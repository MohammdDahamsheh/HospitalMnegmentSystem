using Appleacation.readOnlyRepo;
using Appleacation.repo;
using Infrustracher;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appleacation.unitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private  HospitalContext dbContext;
        public IReposotory<T> Reposotory { get; set; }

        public IReadOnlyReposotory<T> ReadOnlyReposotory { get; set; }

        public UnitOfWork(IReposotory<T> reposotory, IReadOnlyReposotory<T> readOnlyReposotory,HospitalContext context)
        {
            Reposotory = reposotory;
            ReadOnlyReposotory = readOnlyReposotory;
            this.dbContext = context;
        }


        public void Dispose()
        {
           dbContext.Dispose();

        }

        public async Task RollBackAsync()
        {
           
        }

        public async Task<int> SaveAsync()
        {
            return await dbContext.SaveChangesAsync();
        }
    }
}
