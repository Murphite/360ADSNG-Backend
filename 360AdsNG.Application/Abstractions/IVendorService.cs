using _360AdsNG.Application.Dtos;
using _360AdsNG.Application.Dtos.AuthDtos;
using _360AdsNG.Application.Dtos.VendorDtos;

namespace _360AdsNG.Application.Abstractions;

public interface IVendorService
{
    
    Task<Result> UpdateVendorProfile(UpdateVendorProfileDto dto, string userId);

}
