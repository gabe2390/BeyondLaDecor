namespace BeyondLaDecor.Beyond.Data.Models
{
    public abstract class NegotiableCostEntity : DecorEntity
    {
        public decimal? Cost { get; set; }
        public bool Negotiable { get; set; }
    }
}