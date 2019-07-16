using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Models
{
    public class User : IdentityUser<int>, IDecorEntity
    {
        public bool IsAdministrator { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public int? AdministratorId { get; set; }
        public User Administrator { get; set; }
        public Inventory Inventory { get; set; }
        public ICollection<User> Clients { get; set; }
        public ICollection<Package> Packages { get; set; }
        public ICollection<UserSetting> UserSettings { get; set; }
        public ICollection<UserSetting> ClientSpecificUserSettings { get; set; }
        public ICollection<Event> ClientEvents { get; set; }
        public ICollection<Event> AdministratorEvents { get; set; }
        public ICollection<EventType> EventTypes { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<ProductType> ProductTypes { get; set; }
        public ICollection<Service> Services { get; set; }
        public ICollection<ServiceType> ServiceTypes { get; set; }
        public ICollection<Vendor> Vendors { get; set; }
    }
}
