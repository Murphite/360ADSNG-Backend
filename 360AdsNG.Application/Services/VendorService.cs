using _360AdsNG.Application.Abstractions;
using _360AdsNG.Application.Dtos;
using _360AdsNG.Application.Dtos.AuthDtos;
using _360AdsNG.Application.Dtos.VendorDtos;
using _360AdsNG.Domain.Constants;
using _360AdsNG.Domain.Entities;
using _360AdsNG.Domain.Repositories;
using Microsoft.AspNetCore.Identity;
using System.Web;

namespace _360AdsNG.Application.Services;

public class VendorService : IVendorService
{
    private readonly IRepository _repository;
    private readonly UserManager<User> _userManager;
    private readonly IUnitOfWork _unitOfWork;

    public VendorService(IRepository repository, UserManager<User> userManager, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _userManager = userManager;
        _unitOfWork = unitOfWork;
    }

    

    public async Task<Result> UpdateVendorProfile(UpdateVendorProfileDto dto, string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);

        if (user == null)
        {
            return new Error[] { new("User.Error", "User Not Found") };
        }

        var vendor = _repository.GetAll<Vendor>()
            .FirstOrDefault(x => x.UserId == user.Id);

        if (vendor == null)
        {
            return new Error[] { new("Vendor.Error", "Patient Not Found") };
        }

        vendor.CompanyName = dto.CompanyName ?? vendor.CompanyName;
        vendor.Address = dto.Address ?? vendor.Address;

        user.FirstName = dto.FirstName ?? user.FirstName;
        user.LastName = dto.LastName ?? user.LastName;
        user.Email = dto.Email ?? user.Email;
        user.PhoneNumber = dto.PhoneNumber ?? user.PhoneNumber;
        user.Password = dto.Password ?? user.Password;
        user.ConfirmPassword = dto.ConfirmPassword ?? user.ConfirmPassword;

        _repository.Update(vendor);
        await _userManager.UpdateAsync(user);
        await _unitOfWork.SaveChangesAsync();

        return Result.Success();
    }

    
}
