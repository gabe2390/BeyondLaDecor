using System;

namespace BeyondLaDecor.Data.Models
{
    public abstract class Auditable
    {
        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdatedOn { get; set; }
    }
}