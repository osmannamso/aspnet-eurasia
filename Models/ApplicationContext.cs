using Microsoft.EntityFrameworkCore;

namespace eurasia.Models
{
    public sealed class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=MyXmlExport;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public DbSet<Review> Reviews { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}