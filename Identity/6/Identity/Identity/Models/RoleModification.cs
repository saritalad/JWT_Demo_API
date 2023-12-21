using System.ComponentModel.DataAnnotations;

namespace Identity.Models
{
    public class RoleModification
    {
        [Required]
        public string RoleName { get; set; }
        [Key]
        public string RoleId { get; set; }
        
        public string[]? AddIds { get; set; }
        
        public string[]? DeleteIds { get; set; }
    }
}
