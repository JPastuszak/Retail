using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Objects.DataClasses;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Models
{

    public interface IGenericRepository<T>
    {
        void Save(T target);

        void Delete(T target);

        T GetById(int id);

        T GetByGlobalId(Guid id);

        IEnumerable<T> GetAll();

        IEnumerable<T> ExecuteQuery(Func<T, bool> expression);

    }

   /* public interface IGenericRepository<T>: IDisposable
    {
        
        IEnumerable<T> GetAll<T>();
        IEnumerable<T> Find<T>(Expression<Func<T, bool>> predicate);
        T GetSingle<T>(Expression<Func<T, bool>> predicate);
        void Create<T>(T entidade);
        void Edit<T>(T entidade, Expression<Func<T, bool>> predicate) where T : class, IEntityWithKey;
        void Delete<T>(Expression<Func<T, bool>> predicate);
        
    }*/
}
