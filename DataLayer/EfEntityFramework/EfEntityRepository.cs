using DataLayer.Model;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace DataLayer.EfEntityFramework
{
    public class EfEntityRepository<T> : IEntityRepository<T> where T : Entity
    {
        private readonly TutoratDbContext _context;

        public EfEntityRepository()
        {
            _context = new TutoratDbContext();
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsQueryable();
        }

        public T GetById(int id)
        {
            //return _context.Entry(T entity).
            //return _contex.Set<T>().
            return _context.Set<T>().Find(id); //Where(entity => entity.Id == id);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            //T originalEntity = GetById(entity.Id);
            //if (originalEntity != null)
            //{
            //    originalEntity = entity;
            //    _context.Entry(entity).State = EntityState.Modified;
            //    _context.SaveChanges();
            //}

            _context.Set<T>().Attach(entity);
            _context.Entry<T>(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        //public void DropTable(string tableName)
        //{
        //    _context.Database.SqlQuery<Entity>("TRUNCATE TABLE @param1", new SqlParameter("param1", tableName));
        //}
    }
}