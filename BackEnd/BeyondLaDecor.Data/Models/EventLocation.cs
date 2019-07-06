namespace BeyondLaDecor.Beyond.Data.Models
{
    public class EventLocation
    {
        public int EventLocationId { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}