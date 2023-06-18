using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.AuxiliaryEntities;

public class Contact
{
    public Guid Id { get; set; }
    public string PhoneNumber { get; set; } = null!;
    public Address? Address { get; set; }
    public string URL { get; set; } = null!;
}
