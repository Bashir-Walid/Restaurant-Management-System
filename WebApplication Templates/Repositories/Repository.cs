using Microsoft.EntityFrameworkCore;
using WebApplication_Templates.Data;
using WebApplication_Templates.Models;

namespace WebApplication_Templates.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        DataDbContext dbContext;
        DbSet<T> DbSet;

        public Repository(DataDbContext dbContext)
        {
            this.dbContext = dbContext;
            DbSet = dbContext.Set<T>();
        }

        public void Add(T entity)
        {
            entity.CreatedData = DateTime.Now.ToString();
            entity.IsActive = true;

            DbSet.Add(entity);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);

            if (entity == null)
                return;

            DbSet.Remove(entity);
            dbContext.SaveChanges();
        }

        public void Changsteates(int id)
        {
            var entity = GetById(id);

            if (entity == null)
                return;

            entity.IsActive = !entity.IsActive;

            DbSet.Update(entity);
            dbContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return DbSet
                .Where(x => !x.IsDelete)
                .ToList();
        }

        public List<T> GetAllClint()
        {
            return DbSet
                .Where(x => !x.IsDelete && x.IsActive)
                .ToList();
        }

        public T GetById(int id)
        {
            return DbSet
                .FirstOrDefault(x => x.id == id && !x.IsDelete);
        }

        public void Update(T entity)
        {
            entity.UpdatedData = DateTime.Now.ToString();

            DbSet.Update(entity);
            dbContext.SaveChanges();
        }
    }
}