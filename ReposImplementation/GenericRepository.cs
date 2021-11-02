using Data.Abstract;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Data.Implementation
{
    public class GenericRepository<T, K> : IGenericRepository<T, K> where T : BaseEntity<K>
    {
        public readonly RoboCafeDBContext context;

        public GenericRepository(RoboCafeDBContext context)
        {
            this.context = context;
        }

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public void Delete(K id)
        {
            context.Set<T>().Remove(this.Get(id));
        }

        public T Get(K id)
        {
            return context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            T find = this.Get(entity.id);
            context.Entry(find).CurrentValues.SetValues(entity);
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }
    }
}
