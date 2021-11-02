using System.Collections.Generic;

namespace Data.Abstract
{
    public interface IGenericRepository<T, K> 
    {
        void Add(T entity);
        void Update(T entity);
        T Get(K id);
        void Delete(K id);
        List<T> GetAll();
    }
}
