using _360AdsNG.Application.Dtos;
using _360AdsNG.Application.Dtos.UserDtos;

namespace _360AdsNG.Application.Abstractions;

public interface IUserService
{
    Task<Result> UpdateUserProfile(UpdateUserProfileDto dto, string userId);
}
