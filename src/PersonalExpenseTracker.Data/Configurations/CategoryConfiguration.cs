using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalExpenseTracker.Core.Entities;

namespace PersonalExpenseTracker.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            
            builder.Property(c => c.Name)
                .HasMaxLength(100)
                .IsRequired();
            
            builder.Property(c => c.Description)
                .HasMaxLength(500);
            
            builder.Property(c => c.Type)
                .HasConversion<int>()
                .IsRequired();
            
            builder.Property(c => c.CreatedAt)
                .IsRequired();
            
            builder.Property(c => c.IsDeleted)
                .HasDefaultValue(false);
            
            // Relationships
            builder.HasOne(c => c.User)
                .WithMany(u => u.Categories)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            
            // Indexes
            builder.HasIndex(c => c.UserId);
            builder.HasIndex(c => new { c.UserId, c.Name }).IsUnique();
            
            // Soft delete filter
            builder.HasQueryFilter(c => !c.IsDeleted);
        }
    }
}