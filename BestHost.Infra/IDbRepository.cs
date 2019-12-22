using System.Collections.Generic;


namespace BestHost.Infra
{
    public interface IDbRepository<T>
    {
        void Add(T entity);
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);
        void Update(T entity);
        T FindById(string Id);
        IEnumerable<T> GetAll();
    }
}
