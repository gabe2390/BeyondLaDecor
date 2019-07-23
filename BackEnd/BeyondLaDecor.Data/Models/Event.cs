using System;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Models
{
    public class Event : DecorEntity
    {
        public int EventId { get; set; }
        public int EventTypeId { get; set; }
        public EventType EventType { get; set; }
        public DateTime Date { get; set; }
        public Package Package { get; set; }
        public int? PackageId { get; set; }
        public User Client { get; set; }
        public int ClientId { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public ICollection<EventLocation> EventLocations { get; set; }
    }
}
