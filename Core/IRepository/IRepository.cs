using System.Linq.Expressions;

namespace Core.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        // T - Employee 
        IEnumerable<T> GetAll();
        List<T>  Get(Expression<Func<T, bool>> filter);
        T? Find(int Id);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
        
    }
}
