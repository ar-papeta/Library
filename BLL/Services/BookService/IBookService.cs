using DAL.Entities.PublicationEnteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.BookService;

public interface IBookService
{
    public void AddBook(Book book);
    public IEnumerable<Book> GetBooks(Expression<Func<Book, bool>> filter = null!);
    public void DeleteBook(Guid id);
    public Book GetBookById(Guid id);
    public void DeleteBook(Book book);
    public Book UpdateBook(Book book);
}
