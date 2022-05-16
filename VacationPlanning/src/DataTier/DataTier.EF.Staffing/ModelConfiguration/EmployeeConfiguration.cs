using ApplicationTier.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier.EF.Staffing.ModelConfiguration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> modelBuilder)
        {
            modelBuilder
                    .ToTable("Employees")
                    .HasKey(e => e.Id);
            
          /*  modelBuilder
                    .HasOne(e => e.OrgStructure)
                    .WithMany(p => p)
                    .HasForeignKey(e => e.OrgStructureId);
          */ 
            
            modelBuilder
                    .Property(p => p.FirstName)
                    .IsRequired()
                    .HasMaxLength(30);
            modelBuilder
                    .Property(p => p.LastName)
                    .IsRequired()
                    .HasMaxLength(30);
            modelBuilder
                    .Property(p => p.Role)
                    .IsRequired();
            modelBuilder
                    .Property(p => p.Email)
                    .IsRequired()
                    .HasMaxLength(50);
            modelBuilder
                    .Property(p => p.OrgStructure)
                    .IsRequired();
        }
    }
}
