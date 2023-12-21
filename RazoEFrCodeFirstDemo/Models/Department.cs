using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RazoEFrCodeFirstDemo.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Department Name is required")]
        [DisplayName("Department Name")]
        [StringLength(30, ErrorMessage = "Must be between 3 and 30 characters", MinimumLength = 3)]
        public string?  Name { get; set; }
        public ICollection<Employee>? employees { get; set; }
    }
}