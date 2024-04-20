using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Entities;

public class UserEntity : IdentityUser
{
    [ProtectedPersonalData]
    public string FirstName { get; set; } = null!;

    [ProtectedPersonalData]
    public string LastName { get; set; } = null!;

    public string? Biography { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Modified { get; set; }

    public string? ImageUrl { get; set; } = "profile-image.svg";

    public ICollection<AddressEntity> Addresses { get; set; } = [];
}
