using System.Collections.Generic;

namespace BeyondLaDecor.Data.Models
{
    public class EventType : DecorEntity
    {
        public int EventTypeId { get; set; }
        public string Name { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}