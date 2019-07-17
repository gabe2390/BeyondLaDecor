using System;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Api.DomainModels
{
    public class EventModel : DecorEntityApiModel
    {
        public int EventId { get; set; }
        public int EventTypeId { get; set; }
        public EventTypeModel EventType { get; set; }
        public DateTime Date { get; set; }
        public string LocationName { get; set; }
        public string Address { get; set; }
        public PackageModel Package { get; set; }
        public int? PackageId { get; set; }
        public UserModel Client { get; set; }
        public int ClientId { get; set; }
        public int Capacity { get; set; }
        public int? TableCount { get; set; }
        public ICollection<TaskModel> Tasks { get; set; }
        public ICollection<EventLocationModel> EventLocations { get; set; }
    }
}
