namespace BeyondLaDecor.Beyond.Data.Models
{
    public abstract class DecorEntity : Auditable, IDecorEntity
    {
        public int? AdministratorId { get; set; }
        public User Administrator { get; set; }
    }
}
