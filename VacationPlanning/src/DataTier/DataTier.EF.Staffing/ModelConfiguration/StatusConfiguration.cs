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
    public class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> modeBuilder)
        {
            modeBuilder
                .ToTable("Statuses")
                .HasKey(s => s.Id);
            modeBuilder
                .Property(s => s.StatusName)
                .IsRequired()
                .HasMaxLength(30);
        }
    }
}
