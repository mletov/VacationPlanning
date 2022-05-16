namespace ApplicationTier.Domain.Entities
{
/// <summary>
/// Состояние отпуска или командировки  ( может не понадобится )
/// </summary>
    public class Status:
        BaseEntity
    {
        public string StatusName { get; set; }
        public Vacation Vacation { get; set; }
    }
}