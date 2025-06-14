namespace ApiReservas.DTOs
{
    public class ClientDTO : IEntity
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public string? Neighborhood { get; set; }
        public string? Location { get; set; }
        public required string Phone { get; set; }
        public string? Email { get; set; }
    }
}
