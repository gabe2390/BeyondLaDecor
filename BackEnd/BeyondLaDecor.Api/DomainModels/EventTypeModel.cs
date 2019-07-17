using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Api.DomainModels
{
    public class EventTypeModel : DecorEntityApiModel
    {
        public int EventTypeId { get; set; }
        public string Name { get; set; }
        public ICollection<EventModel> Events { get; set; }
    }
}