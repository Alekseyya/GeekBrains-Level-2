using System.Collections.Generic;
using System.Data.Entity;

using EFApplicationCF.Model;

namespace EFApplicationCF.Method
{
    class ArtistsController
    {
        MusicContext dbContext;

        public ArtistsController()
        {
            dbContext = new MusicContext();            
        }

        public IList<Artist> GetArtists()
        {
            dbContext.Artists.Include(x => x.Album).Load();
            return dbContext.Artists.Local.ToBindingList();
        }

        public void DeleteArtist(Artist artist)
        {
            Artist _artist = dbContext.Artists.Find(artist.Id);
            dbContext.Artists.Remove(_artist);
            dbContext.SaveChanges();
        }

        public void InsertArtist(Artist artist)
        {
            dbContext.Artists.Add(artist);
            dbContext.SaveChanges();
        }

        public void UpdateArtist(Artist artist)
        {
            Artist _artist = dbContext.Artists.Find(artist.Id);

            _artist.Name = artist.Name;
            _artist.Description = artist.Description;
            
            dbContext.SaveChanges();
        }
    }
}
