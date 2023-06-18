using DAL.Entities.PersonsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.AuxiliaryEntities;

public class SeasonTicket
{
    public Guid Id { get; set; }
    public TicketType TicketType { get; set; }
    public decimal Price { get; set; }

}

public enum TicketType
{
    Base,
    Premium,
}
