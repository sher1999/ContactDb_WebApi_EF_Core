using Infrastruvture.Data;

namespace Infrastruvture.Services
{
    public abstract class GenericGrud<T> where T : class
    {
       private DataContext _context;
       public GenericGrud(DataContext context)
       {
        _context=context;
       }
        public virtual List<T> Get() => _context.Set<T>().ToList();

        public virtual T Get(int id) => _context.Set<T>().Find(id);
        public virtual void Add(T entity){
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }
        public virtual void Update(T entity){
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
        public virtual  void Delete(int id){
            var entity = _context.Set<T>().Find(id);
             _context.Set<T>().Remove(entity);
             _context.SaveChanges();
        }
    }
}