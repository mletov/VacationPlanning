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
    public class VacationConfiguration : IEntityTypeConfiguration<Vacation>
    {
        public void Configure(EntityTypeBuilder<Vacation> modelBuilder)
        {
            modelBuilder
                .ToTable("Vacations")
                .HasKey(v => v.Id);
            
            
            modelBuilder
                .HasOne(v => v.Employee)
                .WithMany(e => e.Vacation)
           /*     .HasForeignKey<Employee>(e => e.VacationId)*/;
             
            modelBuilder
                .HasOne(v => v.Status)
                .WithOne(s => s.Vacation)
                .HasForeignKey<Vacation>(s => s.StatusId);
            modelBuilder
                .HasOne(vt => vt.VacationType)
                .WithMany(v => v.Vacations)
                .HasForeignKey(s => s.VacationTypeId);
            modelBuilder
                .Property(v => v.DateStart)
                .IsRequired();
            modelBuilder
                .Property(v => v.Status)
                .IsRequired();
            modelBuilder
                .Property(v => v.DateEnd)
                .IsRequired();
        }
    }
}
