namespace BeyondLaDecor.Beyond.Api.DomainModels
{
    public abstract class NegotiableCostEntity : DecorEntityApiModel
    {
        public decimal? Cost { get; set; }
        public bool Negotiable { get; set; }
    }
}