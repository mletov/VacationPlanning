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
    public class DocumentsConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> modelBuilder)
        {
            modelBuilder
                    .ToTable("Documents")
                    .HasKey(d => d.Id);
            modelBuilder
                    .Property(d => d.DocumentName)
                    .IsRequired()
                    .HasMaxLength(30);
            modelBuilder
                    .Property(d => d.DocumentTemplate)
                    .IsRequired();
        }
    }
}
