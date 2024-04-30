using Microsoft.EntityFrameworkCore;

namespace EfcoreOperation.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
                
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>().HasData(
            new Language()
            {
                Id = 1,
                Title = "Hindi",
                Decription = "Hindi"

            },
            new Language()
            {
                Id = 2,
                Title = "English",
                Decription = "English"

            });
        }


      public  DbSet<Book> Books { get; set; }
      public  DbSet<Language> Languages { get; set; }
    }
}
