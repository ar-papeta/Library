using DAL.Db.Repositories;
using DAL.Entities.AuxiliaryEntities;
using DAL.Entities.PersonsEntities;
using DAL.Entities.PublicationEnteties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Db.Uof;

public interface IUnitOfWork
{
    public IRepository<Author> Authors { get; }
    public IRepository<Book> Books { get; }
    public IRepository<Ebook> Ebooks { get; }
    public IRepository<Journal> Journals { get; }
    public IRepository<PublicationItem> PublicationItems { get; }
    public IRepository<Publisher> Publishers { get; }
    public IRepository<Review> Reviews { get; }
    public IRepository<Tag> Tags { get; }
    public IRepository<Visitor> Visitors { get; }
    public IRepository<Address> Addresses { get; }
    public IRepository<Contact> Contacts { get; }
    public IRepository<LibraryInfo> LibraryInfos { get; }
    public IRepository<SeasonTicket> SeasonTickets { get; }
    public IRepository<ActiveItem> ActiveItems { get; }
    public void Save();
}
