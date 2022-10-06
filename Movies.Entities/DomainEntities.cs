using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Movies.Entities
{
    public class DomainEntities
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; } = string.Empty;

        public DateTime? Updated { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; } = string.Empty;

        public bool Deleted { get; set; } = false;
    }
}
