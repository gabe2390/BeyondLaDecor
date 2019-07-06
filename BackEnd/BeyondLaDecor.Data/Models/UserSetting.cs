namespace BeyondLaDecor.Beyond.Data.Models
{
    public class UserSetting
    {
        public int UserSettingId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int SettingId { get; set; }
        public Setting Setting { get; set; }
        public bool Enabled { get; set; }
        public int? ClientId { get; set; }
        public User Client { get; set; }
    }
}