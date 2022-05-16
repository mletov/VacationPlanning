namespace ApplicationTier.Domain.Entities
{

    public class Setting:
    BaseEntity
    {
        public string SettingName { get; set; }
        
        public string SettingType { get; set; }
        
        public int  SettingValue { get; set; }
    }
}