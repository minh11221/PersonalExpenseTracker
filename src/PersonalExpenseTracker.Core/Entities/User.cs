using System.ComponentModel.DataAnnotations;

namespace PersonalExpenseTracker.Core.Entities
{
    public class User : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        
        [Required]
        [MaxLength(255)]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [MaxLength(255)]
        public string PasswordHash { get; set; }
        
        public bool IsActive { get; set; } = true;
        
        public DateTime? LastLoginAt { get; set; }
        
        // Navigation properties
        public virtual ICollection<Expense> Expenses { get; set; } = new List<Expense>();
        public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
    }
}