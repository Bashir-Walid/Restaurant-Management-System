using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using WebApplication_Templates.Models;

namespace WebApplication_Templates.Data.Interceptors
{
    public class SoftDeleteInterceptors : SaveChangesInterceptor
    {
        public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
        {
            var dbContext = eventData.Context;
            if (dbContext is null)
            {
                return new InterceptionResult<int>();
            }
            var models = dbContext.ChangeTracker.Entries<BaseEntity>();

            foreach (var item in models)
            {
                if (item.State == EntityState.Deleted)
                {
                    item.State = EntityState.Modified;
                    item.Entity.IsDelete = true;
                }


            }
            return base.SavingChanges(eventData, result);
        }


    }
}
