using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Movies.Entities
{
    public class Users : DomainEntities
    {
        [Required]
        [StringLength(50)]
        public string UserName { get; set; } = string.Empty;

        [JsonIgnore]
        public string PasswordHash { get; set; } = string.Empty;

        [StringLength(500)]
        public string Email { get; set; } = string.Empty;

        [NotMapped]
        public string Token { get; set; } = string.Empty;
    }
}
