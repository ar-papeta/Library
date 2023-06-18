using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.AuxiliaryEntities;

public class LibraryInfo
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTime Schedule { get; set; }
    public Contact? Contact { get; set; }
}
