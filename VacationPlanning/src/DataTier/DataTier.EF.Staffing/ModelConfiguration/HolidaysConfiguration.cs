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
    public class HolidaysConfiguration : IEntityTypeConfiguration<Holiday>
    {
        public void Configure(EntityTypeBuilder<Holiday> modelBuilder)
        {
            modelBuilder
                    .ToTable("Holidays")
                    .HasKey(h => h.Id);
            modelBuilder
                    .Property(h => h.DateStart)
                    .IsRequired();
            modelBuilder
                    .Property(h => h.DateEnd)
                    .IsRequired();
        }
    }
    
}
