using BuyTheBook.Models.Entities.Books;
using BuyTheBook.Models.Entities.Categories;
using BuyTheBook.Models.Entities.Identitty;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyTheBook.Core.Context
{
    public class BuyTheBookDbContext : IdentityDbContext<ApplicationUser,ApplicationRole, int>
    {
        public BuyTheBookDbContext(DbContextOptions<BuyTheBookDbContext> dbContext) : base(dbContext)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Book>();
            builder.Entity<Category>();
        }
    }
}
