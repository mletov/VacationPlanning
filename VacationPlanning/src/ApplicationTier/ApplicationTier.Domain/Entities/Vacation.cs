namespace ApplicationTier.Domain.Entities
{

    public class Vacation:
        BaseEntity
    {
        public Guid EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        
        public DateTime DateStart { get; set; }
        
        public  DateTime DateEnd { get; set; }
        
        //public Vacation Vacation { get; set; } что тут должно быть? ссылку класса на самого себя сделать нельзя
        public Guid StatusId { get; set; }
        
        public virtual Status Status { get; set; }
        
        public string Comment { get; set; }
        public Guid VacationTypeId { get; set; }
        public virtual VacationType VacationType  { get; set; }
    }
}