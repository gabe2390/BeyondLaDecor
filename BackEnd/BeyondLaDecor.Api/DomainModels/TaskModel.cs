using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace BeyondLaDecor.Beyond.Api.DomainModels
{
    public class TaskModel : DecorEntityApiModel
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public bool Completed { get; set; }
        public int? EventId { get; set; }
        public EventModel Event { get; set; }
        public int? ServiceId { get; set; }
        public ServiceModel Service { get; set; }
    }
}