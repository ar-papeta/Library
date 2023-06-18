using DAL.Entities.PersonsEntities;
using DAL.Entities.PublicationEnteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.VisitorService;

public interface IVisitorService
{
    public void AddVisitor(Visitor visitor);
    public IEnumerable<Visitor> GetVisitors(Expression<Func<Visitor, bool>> filter = null!);
    public void DeleteVisitor(Guid id);
    public Visitor GetVisitorById(Guid id);
    public void DeleteVisitor(Visitor visitor);
    public Visitor UpdateVisitor(Visitor visitor);
}
