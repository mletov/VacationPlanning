namespace ApplicationTier.Domain.Entities
{
    public class VacationType:
        BaseEntity
    {
        public string VacationName { get; set; } 
        public virtual ICollection<Vacation> Vacations { get; set; }
    }
}