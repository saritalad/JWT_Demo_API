using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RazoEFrCodeFirstDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Department Name is required")]
        [DisplayName("Department Name")]
        [StringLength(30, ErrorMessage = "Must be between 3 and 30 characters", MinimumLength = 3)]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [StringLength(20, ErrorMessage = "Must be between 5 and 50 characters", MinimumLength = 5)]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Must be a valid email")]
        public string? Email { get; set; }

        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        public Department? Department { get; set; }

    }
}