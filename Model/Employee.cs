using System.ComponentModel.DataAnnotations;

namespace Employee_Manager_System_App.Model
{
    public class Employee
    {
        [Key]   
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        public string Email { get; set; }

        [Required]
        [MaxLength(10)]
        [MinLength(10)]
        public string ContactNo { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }

        [Required]
        [MaxLength(50)]
        public string Address { get; set; }

        public string AddedBy { get; set; }
        public DateTime AddedAt { get; set; } = DateTime.UtcNow;
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
