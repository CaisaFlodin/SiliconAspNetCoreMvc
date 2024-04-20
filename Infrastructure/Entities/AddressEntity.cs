using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities;

public class AddressEntity
{
    [Key]
    public int Id { get; set; }

    public string AddressLine_1 { get; set; } = null!;

    public string? AddressLine_2 { get; set; }

    public string PostalCode { get; set; } = null!;

    [StringLength(50)]
    public string City { get; set; } = null!;

    public string UserId { get; set; } = null!;
    public UserEntity User { get; set; } = null!;
}
