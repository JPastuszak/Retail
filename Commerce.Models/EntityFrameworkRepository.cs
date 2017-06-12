using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Commerce.Models
{
    public class EntityFrameworkRepository<T>: IGenericRepository<T> where T : DataEntity
    {
        public void Save(T target)
        {
            DatabaseContext context = null;

            using (context = new DatabaseContext())
            {
                if (target.Id == 0)
                    context.Set<T>().Add(target);
                else
                    context.Entry(target).State = EntityState.Modified;

                context.SaveChanges();
            }
        }

        public void Delete(T target)
        {
            DatabaseContext context = null;

            using (context = new DatabaseContext())
            {
                context.Entry(target).State = EntityState.Deleted;

                context.Set<T>().Remove(target);

                context.SaveChanges();
            }
        }

        public T GetById(int id)
        {
            return ExecuteQuery(c => c.Id == id).FirstOrDefault();
        }

        public T GetByGlobalId(Guid id)
        {
            return ExecuteQuery(c => c.GlobalId == id).FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return ExecuteQuery(c => c.Id > 0);
        }

        public IEnumerable<T> ExecuteQuery(Func<T, bool> expression)
        {
            List<T> returnValue = null;

            using (DatabaseContext context = new DatabaseContext())
            {
                var query = context.Set<T>().Where(expression);

                returnValue = new List<T>();

                if (query.Count() > 0)
                    returnValue.AddRange(query);
            }

            return returnValue;
        }
        
    }
}
