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
        // 💡 HATIRLATICI: @ işareti \ kaçış karakterini iptal eder. 
        // Sıralama: Nerede? (Server) + Hangisi? (Database) + Güvenlik? (Trusted)
        // Server=(localdb)\mssqllocaldb -> Bilgisayarımdaki yerel SQL adresi
        // Database=FlashCardDB -> Veritabanı kutusunun adı
        // Trusted_Connection=true -> Windows kullanıcım ile şifresiz gir.
        public DbSet<Word>Words { get; set; }   

        public DbSet<Language> Languages { get; set; }
        
    }
}