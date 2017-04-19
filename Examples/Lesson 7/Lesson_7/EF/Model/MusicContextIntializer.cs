using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace EFApplicationCF.Model
{
    public class MusicContextIntializer : DropCreateDatabaseAlways<MusicContext>
    {
        protected override void Seed(MusicContext context)
        {
            context.Artists.AddRange(new List<Artist>
            {
                new Artist {  Name = "Трифонов Трифон Сидорович", Description = "Скрипка" },
                new Artist {  Name = "Иванов Иван Иванович", Description = "Саксофон" },
                new Artist {  Name = "Петров Петр Ильич", Description = "Барабан" }
            });

            context.SaveChanges();

            context.Albums.AddRange(new List<Album>
            {
                new Album { Name = "Альбом 1", Id = 1, Artist = context.Artists.Where(x => x.Id == 1).FirstOrDefault()},
                new Album { Name = "Альбом 2", Id = 2, Artist = context.Artists.Where(x => x.Id == 2).FirstOrDefault()},
                new Album { Name = "Альбом 3", Id = 3, Artist = context.Artists.Where(x => x.Id == 3).FirstOrDefault()}
            });

            context.SaveChanges();

            context.Songs.AddRange(new List<Song>
            {
                new Song { Name = "Песня 1", Album = context.Albums.Where(x => x.Id == 1).FirstOrDefault()},
                new Song { Name = "Песня 2", Album = context.Albums.Where(x => x.Id == 2).FirstOrDefault()},
                new Song { Name = "Песня 3", Album = context.Albums.Where(x => x.Id == 3).FirstOrDefault()}
            });

            context.SaveChanges();
        
        }
    }
}