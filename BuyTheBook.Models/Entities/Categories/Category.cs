using BuyTheBook.Models.Entities.Books;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuyTheBook.Models.Entities.Categories
{
    [Table("Category")]
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
