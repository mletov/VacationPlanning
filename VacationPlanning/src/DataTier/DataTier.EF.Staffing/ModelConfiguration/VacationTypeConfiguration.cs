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
    internal class VacationTypeConfiguration : IEntityTypeConfiguration<VacationType>
    {
        public void Configure(EntityTypeBuilder<VacationType> modelBuilder)
        {
            modelBuilder
                .ToTable("VacationTypes")
                .HasKey(vt => vt.Id);
            modelBuilder
                .Property(vt => vt.VacationName)
                .IsRequired()
                .HasMaxLength(30);
        }
    }
}
