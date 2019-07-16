namespace BeyondLaDecor.Beyond.Data.Models
{
    public interface IDecorEntity
    {
        int? AdministratorId { get; set; }
        User Administrator { get; set; }
    }
}