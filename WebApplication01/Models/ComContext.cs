using Data.Moder;
using Microsoft.EntityFrameworkCore;


namespace WebApplication01.Models
{
    public class ComContext : DbContext
    {
        public ComContext(DbContextOptions<ComContext> options) :base (options) { }
        public DbSet<role> Roles { get; set; }
        public DbSet<Article> Articles { get; set; }    
        public DbSet<Category> Categories { get; set; }
      
        public DbSet<Product> Products { get; set; }
        public DbSet<Member> Members { get; set; }

        public DbSet<Authorlized> Authorlizeds { get; set; }
        public DbSet<Group> Groups { get; set; }

    }
}
