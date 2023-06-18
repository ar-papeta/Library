using DAL.Db.Uof;
using DAL.Entities.PublicationEnteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.BookService;

public class BookService : IBookService
{
    private readonly IUnitOfWork _database;

    public BookService(IUnitOfWork database)
    {
        _database = database;
    }

    public void AddBook(Book book)
    {
        _database.Books.Insert(book);
        _database.Save();
    }

    public void DeleteBook(Guid id)
    {
        _database.Books.Delete(id);
        _database.Save();
    }

    public void DeleteBook(Book book)
    {
        _database.Books.Delete(book);
        _database.Save();
    }

    public Book GetBookById(Guid id)
    {
        return _database.Books.GetByID(id);
    }

    public IEnumerable<Book> GetBooks(Expression<Func<Book, bool>> filter = null!)
    {
        return _database.Books.Get(filter);
    }

    public Book UpdateBook(Book book)
    {
        _database.Books.Update(book);
        _database.Save();
        return book;
    }
    
}
