using _360AdsNG.Application.Abstractions;
using _360AdsNG.Application.Dtos;
using _360AdsNG.Application.Dtos.UserDtos;
using _360AdsNG.Domain.Entities;
using _360AdsNG.Domain.Repositories;
using Microsoft.AspNetCore.Identity;

namespace _360AdsNG.Application.Services;

public class UserService : IUserService
{
    private readonly IRepository _repository;
    private readonly UserManager<User> _userManager;
    private readonly IUnitOfWork _unitOfWork;
        
    public UserService(IRepository repository, UserManager<User> userManager, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _userManager = userManager;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> UpdateUserProfile(UpdateUserProfileDto dto, string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);

        if (user == null)
        {
            return new Error[] { new ( "User.Error", "User Not Found" ) };
        }

        var userProfile = _repository.GetAll<User>()
        .FirstOrDefault(x => x.Id == user.Id);

        if (userProfile == null)
        {
            return new Error[] { new("UserProfile.Error", "User Profile Not Found") };
        }

        userProfile.ImageUrl = dto.ImageUrl ?? userProfile.ImageUrl;
        userProfile.Email = dto.Email ?? userProfile.Email;
        userProfile.Occupation = dto.Occupation ?? userProfile.Occupation;
        userProfile.PhoneNumber = dto.PhoneNumber ?? userProfile.PhoneNumber;
        userProfile.Address = dto.ResidentialAddress ?? userProfile.Address;
        userProfile.FirstName = dto.FirstName ?? userProfile.FirstName;
        userProfile.LastName = dto.LastName ?? userProfile.LastName;
        userProfile.Password = dto.Password ?? userProfile.Password;
        userProfile.ConfirmPassword = dto.ConfirmPassword ?? userProfile.ConfirmPassword;

        _repository.Update(userProfile);
        await _userManager.UpdateAsync(userProfile);
        await _unitOfWork.SaveChangesAsync();

        return Result.Success();
    }
}
