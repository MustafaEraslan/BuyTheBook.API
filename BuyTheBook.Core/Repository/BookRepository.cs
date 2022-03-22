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
        public IEnumerable<Book> GetAll()
        {
            return _context.Books.ToList();
        }
        public Book GetById(int bookId)
        {
            return _context.Books.FirstOrDefault(x => x.Id == bookId);
        }
        public void Insert(Book bookEntity)
        {
            if (bookEntity != null)
            {
                _context.Books.Add(bookEntity);
                _context.SaveChanges();
            }
        }
        public void Update(Book bookEntity)
        {
            if (bookEntity != null)
            {
                _context.Entry(bookEntity).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
        public void Delete(int bookId)
        {
            Book BookEntity = _context.Books.Find(bookId);
            _context.Books.Remove(BookEntity);
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
    }
}
