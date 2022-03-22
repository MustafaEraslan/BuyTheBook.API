using BuyTheBook.BusinessLogic.Abstract;
using BuyTheBook.Core.Repository;
using BuyTheBook.Models.Entities.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyTheBook.BusinessLogic.Services
{
    public class BookServices : IBookServices
    {
        private readonly IBookRepository _repository;

        public BookServices(IBookRepository repository)
        {
            _repository = repository;
        }

        public void AddBook(Book bookEntity)
        {
            _repository.Insert(bookEntity);
        }

        public void DeleteBook(int bookId)
        {
           _repository.Delete(bookId);
        }

        public IEnumerable<Book> GetAllBooks()
        {
           return _repository.GetAll();
        }

        public Book GetBookById(int bookId)
        {
            return _repository.GetById(bookId);
        }


        public void UpdateBook(Book bookEntity)
        {
            _repository.Update(bookEntity);
        }
    }
}
