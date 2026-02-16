using Flashcard.Entities;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Tools;

namespace Flashcard.DataAccess

{
    public class FlashCardDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//encapsulation 
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb;Database = FlashCardDB;Trusted_Connection = True");
        }

        public DbSet<Word>Words { get; set; }   
        
    }
}