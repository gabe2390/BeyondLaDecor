using System;

namespace BeyondLaDecor.Beyond.Api.DomainModels
{
    public abstract class AuditableModel
    {
        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdatedOn { get; set; }
    }
}