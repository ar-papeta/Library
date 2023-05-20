using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace DAL.Db.Repositories;

public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private LibraryContext _context;
    public DbSet<TEntity> dbSet;
    public GenericRepository(LibraryContext context)
    {
        _context = context;
        dbSet = context.Set<TEntity>();
    }

    public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null)
    {
        IQueryable<TEntity> query = dbSet;

        if (filter != null)
        {
            query = query.Where(filter);
        }

        return query.ToList();
    }

    public virtual TEntity GetByID(Guid? id)
    {
        return dbSet.Find(id);
    }

    public virtual void Insert(TEntity entity)
    {
        dbSet.Add(entity);
    }

    public virtual void Update(TEntity entityToUpdate)
    {
        dbSet.Attach(entityToUpdate);

        _context.Entry(entityToUpdate).State = EntityState.Modified;
    }

    public virtual void Delete(Guid id)
    {
        TEntity entityToDelete = dbSet.Find(id);
        Delete(entityToDelete);
    }

    public virtual void Delete(TEntity entityToDelete)
    {
        if (_context.Entry(entityToDelete).State == EntityState.Detached)
        {
            dbSet.Attach(entityToDelete);
        }
        dbSet.Remove(entityToDelete);
    }
}
