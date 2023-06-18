using DAL.Entities.PublicationEnteties;
using DAL.Entities.AuxiliaryEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.PersonsEntities;

public class Visitor
{
    public Guid Id { get; set; }
    public VisitorRole Role { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public Contact? Contact { get; set; }
    public IEnumerable<ActiveItem>? ActiveItems { get; set; }
    public IEnumerable<PublicationItem>? PublicationItems { get; set; }
    public SeasonTicket? SeasonTicket { get; set; } = null!;
    public string? Password { get; set; }
    public string? Email { get; set; }
}

public enum VisitorRole
{
    User,
    Manager,
    Admin
}
