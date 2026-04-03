using Infrustracher;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appleacation.repo
{
    public class Reposetory<T> : IReposotory<T> where T : class
    {
        private HospitalContext context;
        private DbSet<T> dbSet;
        public Reposetory (HospitalContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
            var r=await dbSet.AddAsync(entity);
        }

        public async Task DeleteAsync(T entity)
        {
            var r = await dbSet.FindAsync(entity);
            if (r == null)
            {
                throw new Exception("The entity not found for deleteing");
            }
             dbSet.Remove(r);
        }

        public async Task UpdateAsync(T entity)
        {
            var r = await dbSet.FindAsync(entity);
            if (r == null)
            {
                throw new Exception("The entity not found for updatting");
            }
            dbSet.Update(r);
        }
    }
}
