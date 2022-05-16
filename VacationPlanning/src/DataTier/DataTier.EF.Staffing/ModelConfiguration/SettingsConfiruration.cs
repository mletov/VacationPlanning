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
    public class SettingsConfiruration : IEntityTypeConfiguration<Setting>
    {
        public void Configure(EntityTypeBuilder<Setting> modelBuilder)
        {
            modelBuilder
                .ToTable("Settings")
                .HasKey(s => s.Id);
            modelBuilder
                .Property(s => s.SettingName)
                .IsRequired();
            modelBuilder
                .Property(s => s.SettingType)
                .IsRequired();
            modelBuilder
                .Property(s => s.SettingValue)
                .IsRequired();
        }
    }
}
