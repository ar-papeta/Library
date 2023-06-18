using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.PersonsEntities;

public class Author
{
    public Guid ID { get; set; }
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public float Rate { get; set; }
}
