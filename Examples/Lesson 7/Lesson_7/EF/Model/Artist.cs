using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EFApplicationCF.Model.Base;
using System.Collections.Generic;

namespace EFApplicationCF.Model
{
    [Table("Artists")]
    public class Artist : BaseIdEntity
    {
        public Artist()
        {
            this.Album = new List<Album>();
        }        
        public string Name { get; set; }
        [Column(TypeName = "nvarchar")]
        [MaxLength(500)]
        public string Description { get; set; }

        [Browsable(false)]
        public virtual ICollection<Album> Album { get; set; }

        [NotMapped]
        public string FullName => $"{Name} {Description}";

    }
}
