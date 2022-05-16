namespace ApplicationTier.Domain.Entities;

/// <summary>
/// Роли системы (администраор, сотрудник, HR
/// </summary>
public class Role :
    BaseEntity
{
    public string RoleName { get; set; }
    
    public string Description { get; set; }
}
    
