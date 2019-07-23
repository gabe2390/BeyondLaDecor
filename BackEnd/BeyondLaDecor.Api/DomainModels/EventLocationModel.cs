using System;

namespace BeyondLaDecor.Beyond.Api.DomainModels
{
    public class EventLocationModel : DecorEntityApiModel
    {
        public int EventLocationId { get; set; }
        public int EventId { get; set; }
        public EventModel Event { get; set; }
        public int LocationId { get; set; }
        public LocationModel Location { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int Capacity { get; set; }
        public int? TableCount { get; set; }
    }
}