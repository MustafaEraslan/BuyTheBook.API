using BuyTheBook.Core.GenericReporsitory;
using BuyTheBook.Models.Entities.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyTheBook.Core.Repository
{
    public interface IBookRepository : IGenericRepository<Book> 
    {
    }
}
