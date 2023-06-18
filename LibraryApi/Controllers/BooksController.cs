using BLL.Services.BookService;
using DAL.Entities.PublicationEnteties;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    private readonly IBookService _bookService;

    public BooksController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var books = _bookService.GetBooks();

        return Ok(books);
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult GetById(Guid id)
    {
        var book = _bookService.GetBookById(id);

        return Ok(book);
    }

    [HttpPost]
    public IActionResult Post(Book book)
    {
        _bookService.AddBook(book);

        return Ok();
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteById(Guid id)
    {
        _bookService.DeleteBook(id);

        return NoContent();
    }

    [HttpPatch]
    [Route("{book}")]
    public IActionResult Update(Book book)
    {
        var newBook = _bookService.UpdateBook(book);

        return Ok(newBook);
    }


}
