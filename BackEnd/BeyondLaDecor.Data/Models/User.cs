using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeyondLaDecor.Beyond.Data.Models
{
    public class User : IdentityUser<int>, IDecorEntity
    {
        public string DecorId { get; set; }
        public bool IsAdministrator { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
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
