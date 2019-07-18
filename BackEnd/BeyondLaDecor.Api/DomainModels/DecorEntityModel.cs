namespace BeyondLaDecor.Beyond.Api.DomainModels
{
    public abstract class DecorEntityApiModel : AuditableModel
    {
        public int? AdministratorId { get; set; }
    }
}
