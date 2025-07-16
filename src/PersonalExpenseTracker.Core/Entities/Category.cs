using System.ComponentModel.DataAnnotations;

namespace PersonalExpenseTracker.Core.Entities
{
    public class Category : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        
        [MaxLength(500)]
        public string? Description { get; set; }
        
        [Required]
        public CategoryType Type { get; set; }
        
        [Required]
        public int UserId { get; set; }
        
        // Navigation properties
        public virtual User User { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; } = new List<Expense>();
    }
}