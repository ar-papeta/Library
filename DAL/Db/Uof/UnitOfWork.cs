using DAL.Db.Repositories;
using DAL.Entities.AuxiliaryEntities;
using DAL.Entities.PersonsEntities;
using DAL.Entities.PublicationEnteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Db.Uof;

internal class UnitOfWork : IUnitOfWork
{
    private readonly LibraryContext _context;
    private IRepository<Author> _authorsRepository = null!;
    private IRepository<Book> _booksRepository = null!;
    private IRepository<Ebook> _ebooksRepository = null!;
    private IRepository<Journal> _journalsRepository = null!;
    private IRepository<PublicationItem> _publicationItemsRepository = null!;
    private IRepository<Publisher> _publishersRepository = null!;
    private IRepository<Review> _reviewsRepository = null!;
    private IRepository<Tag> _tagsRepository = null!;
    private IRepository<Visitor> _visitorsRepository = null!;
    private IRepository<Address> _addressesRepository = null!;
    private IRepository<Contact> _contactsRepository = null!;
    private IRepository<LibraryInfo> _libraryInfosRepository = null!;
    private IRepository<SeasonTicket> _seasonTicketsInfosRepository = null!;
    private IRepository<ActiveItem> _activeItemRepository = null!;

    public UnitOfWork(LibraryContext context)
    {
        _context = context;
    }

    public IRepository<Author> Authors => _authorsRepository ??= new GenericRepository<Author>(_context);
    public IRepository<Book> Books => _booksRepository ??= new GenericRepository<Book>(_context);
    public IRepository<Ebook> Ebooks => _ebooksRepository ??= new GenericRepository<Ebook>(_context);

    public IRepository<Journal> Journals => _journalsRepository ??= new GenericRepository<Journal>(_context);

    public IRepository<PublicationItem> PublicationItems => _publicationItemsRepository ??= new GenericRepository<PublicationItem>(_context);

    public IRepository<Publisher> Publishers => _publishersRepository ??= new GenericRepository<Publisher>(_context);

    public IRepository<Review> Reviews => _reviewsRepository ??= new GenericRepository<Review>(_context);

    public IRepository<Tag> Tags => _tagsRepository ??= new GenericRepository<Tag>(_context);

    public IRepository<Visitor> Visitors => _visitorsRepository ??= new GenericRepository<Visitor>(_context);

    public IRepository<Address> Addresses => _addressesRepository ??= new GenericRepository<Address>(_context);

    public IRepository<Contact> Contacts => _contactsRepository ??= new GenericRepository<Contact>(_context);

    public IRepository<LibraryInfo> LibraryInfos => _libraryInfosRepository ??= new GenericRepository<LibraryInfo>(_context);

    public IRepository<SeasonTicket> SeasonTickets => _seasonTicketsInfosRepository ??= new GenericRepository<SeasonTicket>(_context);

    public IRepository<ActiveItem> ActiveItems => _activeItemRepository ??= new GenericRepository<ActiveItem>(_context);

    public void Save()
    {
        _context.SaveChanges();
    }
}
