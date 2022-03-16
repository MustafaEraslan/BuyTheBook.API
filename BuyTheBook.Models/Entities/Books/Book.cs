using BuyTheBook.Models.Entities.Categories;
using BuyTheBook.Models.Entities.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyTheBook.Models.Entities.Books
{
    [Table("Book")]
    public class Book : BaseEntity
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
