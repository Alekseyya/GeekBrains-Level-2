using System.Data.Entity;

namespace EFApplicationCF.Model
{
    public class MusicContext : DbContext
    {
        public MusicContext() : base("name=MusicContainer")
        { Database.SetInitializer(new MusicContextIntializer()); }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}

