using System;

namespace BeyondLaDecor.Beyond.Data.Models
{
    public class EventLocation : DecorEntity
    {
        public int EventLocationId { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? TableCount { get; set; }
        public int Capacity { get; set; }
    }
}