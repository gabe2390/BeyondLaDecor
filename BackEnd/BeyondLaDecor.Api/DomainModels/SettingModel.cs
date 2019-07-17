using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Api.DomainModels
{
    public class SettingModel
    {
        public int SettingId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public SettingTypeModel SettingType { get; set; }
        public ICollection<UserSettingModel> UserSettings { get; set; }
    }
}
