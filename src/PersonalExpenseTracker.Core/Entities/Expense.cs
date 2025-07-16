using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalExpenseTracker.Core.Entities
{
    public class Expense : BaseEntity
    {
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        
        [Required]
        public DateTime Date { get; set; }
        
        [Required]
        public int CategoryId { get; set; }
        
        [Required]
        public int UserId { get; set; }
        
        [MaxLength(1000)]
        public string? Notes { get; set; }
        
        public ExpenseStatus Status { get; set; } = ExpenseStatus.Active;
        
        // Navigation properties
        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
    }
}