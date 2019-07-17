using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Api.DomainModels
{
    public class UserModel : IDecorEntityModel
    {
        public int Id { get; set; }
        public bool IsAdministrator { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public int? AdministratorId { get; set; }
        public UserModel Administrator { get; set; }
        public InventoryModel Inventory { get; set; }
    }
}
