using DAL.Entities.PersonsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.PublicationEnteties;

public class Book : PublicationItem
{
    public IEnumerable<Author> Author { get; set; } = null!;
    public string ImagePath { get; set; } = null!;
    public Genre Genre { get; set; }
}
public enum Genre
{
    Fiction,
    Mystery,
    Romance,
    Fantasy,
    ScienceFiction,
    Biography,
    History,
    Thriller,
    Horror,
    Comedy
}