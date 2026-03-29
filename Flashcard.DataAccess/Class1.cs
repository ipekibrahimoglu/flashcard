using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Tools;
using Flashcard.Entities.Concrete;

namespace Flashcard.DataAccess

{
    public class FlashCardDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//encapsulation 
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb;Database = FlashCardDB;Trusted_Connection = True");
        }

        public DbSet<Word>Words { get; set; }   

        public DbSet<Language> Languages { get; set; }
        
    }
}