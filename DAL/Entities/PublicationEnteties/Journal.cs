using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.PublicationEnteties;

public class Journal : PublicationItem
{
    public string ImagePath { get; set; } = null!;
}
