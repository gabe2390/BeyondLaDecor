using System;

namespace BeyondLaDecor.Data.Models
{
    public class Event : DecorEntity
    {
        public int EventId { get; set; }
        public int EventTypeId { get; set; }
        public EventType EventType { get; set; }
        public DateTime Date { get; set; }
        public string LocationName { get; set; }
        public string Address { get; set; }
        public Package Package { get; set; }
        public int? PackageId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public int Capacity { get; set; }
        public int TableCount { get; set; }

    }
}
