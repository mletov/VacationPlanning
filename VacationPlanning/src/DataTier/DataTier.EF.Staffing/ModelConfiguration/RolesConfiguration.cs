using ApplicationTier.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataTier.EF.Staffing.ModelConfiguration
{

    public class RolesConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> modelBuilder)
        {      
            modelBuilder
            .ToTable("Role")
            .HasKey(p => p.Id);
            modelBuilder
                .Property((p=>p.RoleName))
                .IsRequired()
                .HasMaxLength(30);
            modelBuilder
                .Property((p=>p.Description))
                .IsRequired()
                .HasMaxLength(50);
            
        }
    }
}

