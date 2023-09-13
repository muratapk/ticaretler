using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        protected ApplicationDbContext c = new ApplicationDbContext();
        public void Add(T entity)
        {
            c.Add(entity);
            c.SaveChanges();
        }

        public void Delete(T entity)
        {
            c.Remove(entity);
            c.SaveChanges();
        }

        public List<T> GetAll()
        {
            return c.Set<T>().ToList();
        }

        public List<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            return c.Set<T>().Where(filter).ToList(); ;
        }

        public T GetById(int id)
        {
            return c.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
