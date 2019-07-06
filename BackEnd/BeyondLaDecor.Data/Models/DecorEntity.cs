namespace BeyondLaDecor.Beyond.Data.Models
{
    public abstract class DecorEntity : Auditable, IDecorEntity
    {
        public string DecorId { get; set; }
    }
}
