using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Entities
{
    public class Movies : DomainEntities
    {
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        public int Likes { get; set; } = 0;

        public string Images { get; set; } = string.Empty;

        [NotMapped]
        public bool IsLiked { get; set; } = false;
    }
}
