using ApiReservas.Models;
using System.ComponentModel.DataAnnotations;

public class Client : IEntity
{
    public int Id { get; set; }
    [Required]
    public required string FullName { get; set; }
    public string? Neighborhood { get; set; }
    public string? Lation { get; set; }
    public required string Phone { get; set; }
    public string? Email { get; set; }
    public List<Reservation> Reservation { get; set; } = [];
}