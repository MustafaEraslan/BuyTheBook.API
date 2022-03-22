using BuyTheBook.BusinessLogic.Abstract;
using BuyTheBook.Models.Entities.Books;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BuyTheBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookServices _services;

        public BooksController(IBookServices services)
        {
            _services = services;
        }

        [HttpPost("AddBook")]
        public void AddBook(Book bookEntity)
        {
            _services.AddBook(bookEntity);
        }

        [HttpDelete("DeleteBook")]
        public void DeleteBook(int bookId)
        {
            _services.DeleteBook(bookId);
        }

        [HttpGet("GetAllBooks")]
        public IEnumerable<Book> GetAllBooks()
        {
            return _services.GetAllBooks();
        }

        [HttpGet("GetBookById")]
        public Book GetBookById(int bookId)
        {
           return _services.GetBookById(bookId);
        }

        [HttpPut("UpdateBook")]
        public void UpdateBook(Book bookEntity)
        {
            _services.UpdateBook(bookEntity);
        }
    }
}
