using ApplicationTier.Domain.Entities;

using DataTier.EF.OrganizationStructure.ModelConfiguration;

using Microsoft.EntityFrameworkCore;

namespace DataTier.EF.OrganizationStructure;

public class DataContextStruct : DbContext
{
    public DbSet<OrgStructure> OrgStructures { get; set; }

    public  DataContextStruct(DbContextOptions<DataContextStruct> options)
        :base(options)
    { 
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Vacation;Username=postgres;Password=nhtcrf");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new OrgStructureConfiguration());
    }
}