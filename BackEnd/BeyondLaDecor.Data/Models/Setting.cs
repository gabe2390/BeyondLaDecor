﻿using System.Collections.Generic;

namespace BeyondLaDecor.Data.Models
{
    public class Setting : DecorEntity
    {
        public int SettingId { get; set; }
        public string Name { get; set; }
        public SettingType SettingType { get; set; }
        public ICollection<UserSetting> UserSettings { get; set; }
    }
}