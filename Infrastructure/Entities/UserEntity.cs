namespace Infrastructure.Entities;

public class UserEntity
{
    public string FirstName { get; set; } = null!;
 
    public string LastName { get; set; } = null!;

    public string? Biography { get; set; }

    public string? ImageUrl { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Modified { get; set; }

    public int? AddressId { get; set; }

    public AddressEntity? Address { get; set; }

    public bool IsExternalAccount { get; set; }
}
