using ApplicationTier.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier.EF.OrganizationStructure.ModelConfiguration
{
    internal class OrgStructureConfiguration : IEntityTypeConfiguration<OrgStructure>
    {
        public void Configure(EntityTypeBuilder<OrgStructure> modelBuilder)
        {
            modelBuilder
                .ToTable("OrgStructures")
                .HasKey(os => os.Id);
        }
    }
}
