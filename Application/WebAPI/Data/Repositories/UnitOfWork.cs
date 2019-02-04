using Microsoft.EntityFrameworkCore;

namespace WebAPI.Data.Repositories
{
    public class UnitOfWork
    {
        public DbContext Context { get; }
 
        public UnitOfWork(DbContext context)
        {
            Context = context;
        }
        public void Commit()
        {
            Context.SaveChanges();
        }
 
        public void Dispose()
        {
           Context.Dispose();
        }
    }
}