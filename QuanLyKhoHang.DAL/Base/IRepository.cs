using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.DAL.Base
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Find(params Expression<Func<T, bool>>[] predicates);
        IEnumerable<T> Filter(params Expression<Func<T, bool>>[] predicates);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
