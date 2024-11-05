using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace QuanLyKhoHang.DAL.Base
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly QuanLyKhoHangContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(QuanLyKhoHangContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}
