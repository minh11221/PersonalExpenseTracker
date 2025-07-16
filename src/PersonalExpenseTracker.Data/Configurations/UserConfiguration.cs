using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalExpenseTracker.Core.Entities;

namespace PersonalExpenseTracker.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            
            builder.Property(u => u.FirstName)
                .HasMaxLength(100)
                .IsRequired();
            
            builder.Property(u => u.LastName)
                .HasMaxLength(100)
                .IsRequired();
            
            builder.Property(u => u.Email)
                .HasMaxLength(255)
                .IsRequired();
            
            builder.Property(u => u.PasswordHash)
                .HasMaxLength(255)
                .IsRequired();
            
            builder.Property(u => u.IsActive)
                .HasDefaultValue(true);
            
            builder.Property(u => u.CreatedAt)
                .IsRequired();
            
            builder.Property(u => u.IsDeleted)
                .HasDefaultValue(false);
            
            // Essential indexes only
            builder.HasIndex(u => u.Email);
            
            // Soft delete filter
            builder.HasQueryFilter(u => !u.IsDeleted);
        }
    }
}