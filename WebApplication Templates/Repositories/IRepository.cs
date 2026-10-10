namespace WebApplication_Templates.Repositories
{
    public interface IRepository<T>
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(int id);
        void Changsteates(int id);

        T GetById(int id);

        List<T> GetAll();
        List<T> GetAllClint();

    }
}

