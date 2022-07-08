using System.Linq;

namespace Task.DataAccess.Interfaces
{
    public interface IRepository<T>
        where T : class
    {
        int Create(T item);

        T GetById(int id);

        IQueryable<T> GetAll();

        void Update(T item);

        void Delete(int id);
    }
}
