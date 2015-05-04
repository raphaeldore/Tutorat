using DataLayer.Model;
using System.Linq;

namespace DataLayer
{
    public interface IEntityRepository<T> where T : Entity
    {
        public IQueryable<T> GetAll();
        public T GetById(int id);
        public void Delete(T entity);
        public void Add(T entity);
        public void Update(T entity);
        public void DeleteAll();
    }
}