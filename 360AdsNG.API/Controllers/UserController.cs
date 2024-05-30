using _360AdsNG.API.Dtos;
using _360AdsNG.Application.Abstractions;
using _360AdsNG.Application.Dtos.UserDtos;
using _360AdsNG.Application.Services;
using _360AdsNG.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace _360AdsNG.API.Controllers;

[ApiController]
//[Authorize]
[Route("api/v1/user")]
public class UserController : Controller
{
    private readonly IUserService _userService;
    private readonly UserManager<User> _userManager;
    private readonly ILogger<AuthController> _logger;


    public UserController(IUserService userService, UserManager<User> userManager, ILogger<AuthController> logger)
    {
        _userService = userService;
        _userManager = userManager;
        _logger = logger;
    }

    [HttpPut]
    public async Task<IActionResult> UpdateUserProfile([FromBody] UpdateUserProfileDto dto)
    {
        var userId = _userManager.GetUserId(User);
        var result = await _userService.UpdateUserProfile(dto, userId!);

        if (result.IsFailure)
            return BadRequest(ResponseDto<object>.Failure(result.Errors));

        return Ok(ResponseDto<object>.Success());
    }

}
