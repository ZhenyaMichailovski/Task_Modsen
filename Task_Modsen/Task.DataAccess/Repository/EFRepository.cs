using Microsoft.EntityFrameworkCore;
using System.Linq;
using Task.DataAccess.Interfaces;

namespace Task.DataAccess.Repository
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : class, IId
    {
        DbContext _context;
        DbSet<TEntity> _dbSet;

        public EFRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet.AsNoTracking();
        }

        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public int Create(TEntity item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
            return 0;
        }
        public void Update(TEntity item)
        {
            var entry = _context.Set<TEntity>().FirstOrDefault(x => x.Id == item.Id);

            _context.Entry(entry).CurrentValues.SetValues(item);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var item = GetById(id);
            _dbSet.Remove(item);
            _context.SaveChanges();
        }
    }
}
