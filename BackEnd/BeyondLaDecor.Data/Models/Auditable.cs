using System;

namespace BeyondLaDecor.Beyond.Data.Models
{
    public abstract class Auditable
    {
        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdatedOn { get; set; }
    }
}