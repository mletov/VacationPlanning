namespace ApplicationTier.Domain.Entities
{
    public class Holiday:
        BaseEntity
    {
        public DateTime DateStart { get; set; }
        
        public DateTime DateEnd { get; set; }
    }
}