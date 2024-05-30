using _360AdsNG.Domain.Entities;
using System.Runtime.ExceptionServices;

namespace _360AdsNG.Application.Dtos.VendorDtos;

public class UpdateVendorProfileDto
{
    public string? ImageUrl { get; set; }
    public string? Email { get; set; }
    public string? CompanyName { get; set; }
    public string? PhoneNumber { get; set; }
    public Address? Address { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Password { get; set; }
    public string? ConfirmPassword { get; set; }
}
