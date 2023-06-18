using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.PublicationEnteties;

public class Review
{
    public Guid ID { get; set; }
    public Guid VisitorID { get; set; }
    public string Message { get; set; } = null!;
    public byte Rating { get; set; }
}
