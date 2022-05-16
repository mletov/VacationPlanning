using ApplicationTier.Domain.Entities;

using DataTier.EF.Staffing.ModelConfiguration;

using Microsoft.EntityFrameworkCore;

namespace DataTier.EF.Staffing;

public class DataContextStaffing : DbContext
{
    public DbSet<Document> Documents { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Holiday> Holidays { get; set; }
 //   public DbSet<Position> Positions { get; set; }
    public DbSet<Setting> Settings { get; set; }
    public DbSet<Vacation> Vacations { get; set; }
    public DbSet<VacationType> VacationTypes { get; set; }

    public DataContextStaffing(DbContextOptions<DataContextStaffing> options)
        : base(options)
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
        modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        modelBuilder.ApplyConfiguration(new DocumentsConfiguration());
        modelBuilder.ApplyConfiguration(new HolidaysConfiguration());
        modelBuilder.ApplyConfiguration(new RolesConfiguration());
        modelBuilder.ApplyConfiguration(new SettingsConfiruration());
        modelBuilder.ApplyConfiguration(new StatusConfiguration());
        modelBuilder.ApplyConfiguration(new VacationConfiguration());
        modelBuilder.ApplyConfiguration(new VacationTypeConfiguration());
    }
}



