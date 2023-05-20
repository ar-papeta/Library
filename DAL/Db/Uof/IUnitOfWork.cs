using DAL.Db.Repositories;
using DAL.Models;

namespace DAL.Db.Uof;

public interface IUnitOfWork
{
    public IRepository<User> Users { get; }
    public void Save();
}