namespace ApplicationTier.Domain.Entities
{
     /// <summary>
    /// Документы  и их шаблоны для заполнения  
    /// </summary>
    public class Document:
        BaseEntity
    {
     public string DocumentName { get; set; }
     public string DocumentTemplate { get; set; }
    }
}