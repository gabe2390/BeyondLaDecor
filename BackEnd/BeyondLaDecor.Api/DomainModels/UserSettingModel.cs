namespace BeyondLaDecor.Beyond.Api.DomainModels
{
    public class UserSettingModel
    {
        public int UserSettingId { get; set; }
        public int UserId { get; set; }
        public UserModel User { get; set; }
        public int SettingId { get; set; }
        public SettingModel Setting { get; set; }
        public bool Enabled { get; set; }
        public int? ClientId { get; set; }
        public UserModel Client { get; set; }
    }
}