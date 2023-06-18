using DAL.Db.Uof;
using DAL.Entities.PersonsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.VisitorService;

public class VisitorService : IVisitorService
{
    private readonly IUnitOfWork _database;

    public VisitorService(IUnitOfWork database)
    {
        _database = database;
    }

    public void AddVisitor(Visitor visitor)
    {
        if(GetVisitors(user =>user.Email == visitor.Email).Any())
        {
            throw new Exception("User with this email already exist");
        }
       
        _database.Visitors.Insert(visitor);
        _database.Save();
    }

    public void DeleteVisitor(Guid id)
    {
        _database.Visitors.Delete(id);
        _database.Save();
    }

    public void DeleteVisitor(Visitor visitor)
    {
        _database.Visitors.Delete(visitor);
        _database.Save();
    }

    public Visitor GetVisitorById(Guid id)
    {
        return _database.Visitors.GetByID(id);
    }

    public IEnumerable<Visitor> GetVisitors(Expression<Func<Visitor, bool>> filter = null!)
    {
        return _database.Visitors.Get(filter);
    }

    public Visitor UpdateVisitor(Visitor visitor)
    {
        _database.Visitors.Update(visitor);
        _database.Save();
        return visitor;
    }
}
