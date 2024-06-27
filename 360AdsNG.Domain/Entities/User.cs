using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace _360AdsNG.Domain.Entities;

public class User : IdentityUser, IAuditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? ImageUrl { get; set; }
    public string? Occupation { get; set; }
    public string? BusinessName { get; set; }
    public string? ContactName { get; set; }
    public string? PublicId { get; set; } 
    public string? AddressId { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public string Password { get; set; } = default!;
    public string ConfirmPassword { get; set; } = default!;


    //navigation property
    public Address? Address { get; set; }
}
