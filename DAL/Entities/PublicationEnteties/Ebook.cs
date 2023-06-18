using DAL.Entities.PersonsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.PublicationEnteties;

public class Ebook : Book
{
    public Format Format { get; set; }
}



public enum Format
{
    PDF,
    EPUB,
    MOBI
}