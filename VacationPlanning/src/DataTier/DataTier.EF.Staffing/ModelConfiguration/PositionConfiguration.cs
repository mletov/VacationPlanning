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
    /* Закомментировал, т.к. Position находится в классе OrgStructure
    public class PositionConfiguration : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> modelBuilder)
        {
            modelBuilder
                    .ToTable("Positions")
                    .HasKey(p => p.Id);
            modelBuilder
                    .Property(p => p.PositionName)
                    .IsRequired()
                    .HasMaxLength(30);
            modelBuilder
                    .Property(p => p.Employees);
        }
    }
    */
}
