using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities.PersonsEntities;

namespace DAL.Entities.PublicationEnteties;

public class PublicationItem
{
    public Guid ID { get; set; }
    public string Title { get; set; } = null!;
    public DateTime DatePublished { get; set; }
    public Language Language { get; set; }
    public Publisher Publisher { get; set; } = null!;
    public IEnumerable<Tag> Tags { get; set; } = null!;
    public string Preview { get; set; } = null!;
    public IEnumerable<Review> Reviews { get; set; } = null!;
    public byte Rating { get; set; }
    public decimal Price { get; set; }
    public uint Pages { get; set; }
}

public enum Language
{
    UA,
    EN
}
