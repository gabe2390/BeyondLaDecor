using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace BeyondLaDecor.Beyond.Data.Models
{
    public class Task : DecorEntity
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public bool Completed { get; set; }
        public int? EventId { get; set; }
        public Event Event { get; set; }
        public int? ServiceId { get; set; }
        public Service Service { get; set; }
    }
}