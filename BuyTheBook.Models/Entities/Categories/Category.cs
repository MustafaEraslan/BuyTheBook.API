using BuyTheBook.Models.Entities.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyTheBook.Models.Entities.Categories
{
    public class Category
    {
        public string? Name { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
