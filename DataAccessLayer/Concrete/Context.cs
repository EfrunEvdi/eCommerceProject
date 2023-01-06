using EntitiyLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=eCommerceDB; integrated security=true");
        }
        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<GenreCategory> GenreCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<TraderBuy> TraderBuys { get; set; }
        public DbSet<TraderSell> TraderSells { get; set; }
    }
}
