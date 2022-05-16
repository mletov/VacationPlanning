namespace ApplicationTier.Domain.Entities
{
    public class OrgStructure:
        BaseEntity
    {
        public string PositionName { get; set; }
        
        public Guid ParentId { get; set; }
        
        public int IsFolder { get; set; }
    }
}