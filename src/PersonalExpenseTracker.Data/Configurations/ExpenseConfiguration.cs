using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalExpenseTracker.Core.Entities;

namespace PersonalExpenseTracker.Data.Configurations
{
    public class ExpenseConfiguration : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.HasKey(e => e.Id);
            
            builder.Property(e => e.Amount)
                .HasPrecision(18, 2)
                .IsRequired();
            
            builder.Property(e => e.Description)
                .HasMaxLength(500)
                .IsRequired();
            
            builder.Property(e => e.Date)
                .IsRequired();
            
            builder.Property(e => e.Notes)
                .HasMaxLength(1000);
            
            builder.Property(e => e.Status)
                .HasConversion<int>()
                .IsRequired();
            
            builder.Property(e => e.CreatedAt)
                .IsRequired();
            
            builder.Property(e => e.IsDeleted)
                .HasDefaultValue(false);
            
            // Relationships
            builder.HasOne(e => e.Category)
                .WithMany(c => c.Expenses)
                .HasForeignKey(e => e.CategoryId);
            
            builder.HasOne(e => e.User)
                .WithMany(u => u.Expenses)
                .HasForeignKey(e => e.UserId);
            
            // Essential indexes only
            builder.HasIndex(e => e.UserId);
            
            // Soft delete filter
            builder.HasQueryFilter(e => !e.IsDeleted);
        }
    }
}