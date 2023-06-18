using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.AuxiliaryEntities;

public class Address
{
    public Guid Id { get; set; }
    public string Country { get; set; } = null!;
    public string City { get; set; } = null!;
    public string Street { get; set; } = null!;
    public string Flat { get; set; } = null!;
    public string Postcode { get; set; } = null!;
}
