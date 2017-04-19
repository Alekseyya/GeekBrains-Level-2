using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EFApplicationCF.Model.Base;

namespace EFApplicationCF.Model
{
    using System;
    using System.Collections.Generic;
    
    public class Album : BaseIdEntity
    {
        public Album()
        {
         this.Song = new List<Song>();
        }        
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ArtistId { get; set; }
        [ForeignKey("ArtistId")]
        public virtual Artist Artist { get; set; }
        public virtual ICollection<Song> Song { get; set; }

    }
}
