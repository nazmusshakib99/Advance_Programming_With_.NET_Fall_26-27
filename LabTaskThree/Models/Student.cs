using LabTaskThree.Validations;
using System.ComponentModel.DataAnnotations;

namespace LabTaskThree.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Student ID is required")]
        [StringLength(10, ErrorMessage = "ID cannot exceed 10 characters")]
        public string StudentId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

     

        [Required(ErrorMessage = "GPA is required")]
        [Range(0.0, 4.0, ErrorMessage = "GPA must be between 0.0 and 4.0")]
        public double GPA { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        [MinimumAge(16)]
        [MaximumAge(30)]
        public DateTime DateOfBirth { get; set; }
    }
}

