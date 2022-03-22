using BuyTheBook.Models.Entities.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyTheBook.BusinessLogic.Abstract
{
    public interface IBookServices
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int bookId);
        void AddBook(Book bookEntity);
        void UpdateBook(Book bookEntity);
        void DeleteBook(int bookId);
    }
}
