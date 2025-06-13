public class ClientDTO : IEntity
{
    public int Id { get; set; }
    public required string FullName { get; set; }
}