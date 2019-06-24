using System.Collections.Generic;

namespace BeyondLaDecor.Data.Models
{
    public class User : DecorEntity
    {
        public int UserId { get; set; }
        public bool IsAdministrator { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public ICollection<Event> Events { get; set; }
        public int? AdminstratorId { get; set; }
        public User Administrator { get; set; }
        public ICollection<User> Clients { get; set; }
        public ICollection<UserSetting> UserSettings { get; set; }
        public ICollection<UserSetting> ClientSpecificUserSettings { get; set; }
    }
}
