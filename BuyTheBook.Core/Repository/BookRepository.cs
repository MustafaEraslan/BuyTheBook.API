using BuyTheBook.Core.Context;
using BuyTheBook.Models.Entities.Books;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyTheBook.Core.Repository
{
    public class BookRepository: IBookRepository
    {
        private readonly BuyTheBookDbContext _context;
        public BookRepository(BuyTheBookDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }
        public Book GetBookById(int bookId)
        {
            return _context.Books.Find(bookId);
        }
        public void AddBook(Book bookEntity)
        {
            if (bookEntity != null)
            {
                _context.Books.Add(bookEntity);
            }
        }
        public void UpdateBook(Book bookEntity)
        {
            if (bookEntity != null)
            {
                _context.Entry(bookEntity).State = EntityState.Modified;
            }
        }
        public void DeleteBook(int bookId)
        {
            Book BookEntity = _context.Books.Find(bookId);
            _context.Books.Remove(BookEntity);
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        IEnumerable<Book> IBookRepository.GetAllBooks()
        {
            throw new NotImplementedException();
        }

        Book IBookRepository.GetBookById(int bookId)
        {
            throw new NotImplementedException();
        }

    }
}
