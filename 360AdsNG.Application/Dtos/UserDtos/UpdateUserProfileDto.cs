

using _360AdsNG.Domain.Entities;

namespace _360AdsNG.Application.Dtos.UserDtos;

public class UpdateUserProfileDto
{
    public string? ImageUrl { get; set; }
    public string? Email { get; set; }
    public string? Occupation { get; set; }
    public string? PhoneNumber { get; set; }
    public Address? ResidentialAddress { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Password { get; set; }
    public string? ConfirmPassword { get; set; }
}
