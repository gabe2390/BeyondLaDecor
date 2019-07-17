namespace BeyondLaDecor.Beyond.Api.DomainModels
{
    public interface IDecorEntityModel
    {
        int? AdministratorId { get; set; }
        UserModel Administrator { get; set; }
    }
}