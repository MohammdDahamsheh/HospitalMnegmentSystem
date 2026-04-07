using Infrustracher;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appleacation.readOnlyRepo
{
    public class ReadOnlyReposetory<T> : IReadOnlyReposotory<T> where T : class
    {
        private HospitalContext context;
        private DbSet<T> dbSet;

        public ReadOnlyReposetory(HospitalContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return dbSet;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var result=await dbSet.FindAsync(id);
            if (result == null)
            {
                throw new Exception("No data found");
            }
            return result;
        }
    }
}
