using _360AdsNG.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace _360AdsNG.Domain.Entities;

public class Vendor : Entity, IAuditable
{   
    public string UserId { get; set; }
    public string? AddressId { get; set; }
    public string CompanyName { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public VendorType VendorType { get; set; }


    // Navigation properties
    public User User { get; set; }
    public Address? Address { get; set; }
}
