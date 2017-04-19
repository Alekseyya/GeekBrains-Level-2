using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EFApplicationCF.Model.Base;

namespace EFApplicationCF.Model
{   
    public class Song : BaseIdEntity
    {        
        public string Name { get; set; }
        public string Description { get; set; }
        public int? AlbumId { get; set; }
        [ForeignKey("AlbumId")]
        public virtual Album Album { get; set; }
    }
}
