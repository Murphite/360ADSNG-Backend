using _360AdsNG.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace _360AdsNG.Application.Dtos.AuthDtos;

public class VendorRegisterDto
{
    [Required] public string FirstName { get; init; }
    [Required] public string LastName { get; init; }
    [Required] public string PhoneNumber { get; init; }
    [Required][EmailAddress] public string Email { get; init; }

    [Required(ErrorMessage = "New password is required")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required(ErrorMessage = "Confirm password is required")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Password and confirm password do not match")]
    public string ConfirmPassword { get; set; }
    public VendorType VendorType { get; set; }
}