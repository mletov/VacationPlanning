using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationTier.Domain.Entities
{
    
    /// <summary>
    /// Список сотрудников  
    /// </summary>
    public class Employee:
        BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public string Email { get; set; }

        // Id сотрудника, замещающего на время отпуска
        public Guid ReplacementId { get; set; }

        
        public  Guid RoleId { get; set; }
        
        public virtual Role Role { get; set; }
        
        //public Position Position { get; set; }
        
        /// <summary>
        /// Должность из класса OrgStructure
        /// </summary>
        public Guid OrgStructureId { get; set; }
        [ForeignKey("OrgStructureId")]
        public virtual OrgStructure OrgStructure { get; set; }
        
        
        public Guid VacationId { get; set; }
        public virtual  ICollection<Vacation>  Vacation { get; set; }
        
        
    }
}