public class ReservationDTO : IEntity
{
    public int Id { get; set; }
    public required string ReservationType { get; set; }
}