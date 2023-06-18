using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.PublicationEnteties;

public class Tag
{
    public Guid ID { get; set; }
    public string Description { get; set; } = null!;
}
