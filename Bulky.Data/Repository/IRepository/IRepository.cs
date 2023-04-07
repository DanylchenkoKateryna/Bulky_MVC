using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T:class
    {
        T Get(Expression<Func<T,bool>> filter);
        IEnumerable<T> GetAll();
        void Add(T item);
        void Delete(T item);
        void DeleteRange(IEnumerable<T> items);
    }
}
