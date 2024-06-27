using _360AdsNG.API.Dtos;
using _360AdsNG.API.Extensions;
using _360AdsNG.Application.Abstractions;
using _360AdsNG.Application.Dtos.AuthDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _360AdsNG.API.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;
    private readonly ILogger<AuthController> _logger;

    public AuthController(IAuthService authService, ILogger<AuthController> logger)
    {
        _authService = authService;
        _logger = logger;
    }

    [HttpPost("Register")]
    public async Task<IActionResult> Register([FromBody] RegisterUserDto registerUserDto)
    {
        var result = await _authService.Register(registerUserDto);

        if (result.IsFailure)
            return BadRequest(ResponseDto<object>.Failure(result.Errors));

        return Ok(ResponseDto<object>.Success());
    }

    [HttpPost("BusinessRegister")]
    public async Task<IActionResult> BusinessRegister([FromBody] RegisterBusinessDto registerBusinessDto)
    {
        var result = await _authService.RegisterBusiness(registerBusinessDto);

        if (result.IsFailure)
            return BadRequest(ResponseDto<object>.Failure(result.Errors));

        return Ok(ResponseDto<object>.Success());
    }

    [HttpPost("VendorRegister")]
    public async Task<IActionResult> VendorRegister([FromBody] VendorRegisterDto registerAdminDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ResponseDto<object>.Failure(ModelState.GetErrors()));        

        var result = await _authService.RegisterVendor(registerAdminDto);

        if (result.IsFailure)
            return BadRequest(ResponseDto<object>.Failure(result.Errors));

        return Ok(ResponseDto<object>.Success());
    }

    [HttpPost("AdminRegister")]
    public async Task<IActionResult> AdminRegister([FromBody] AdminRegisterDto registerAdminDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ResponseDto<object>.Failure(ModelState.GetErrors()));

        var result = await _authService.RegisterAdmin(registerAdminDto);

        if (result.IsFailure)
            return BadRequest(ResponseDto<object>.Failure(result.Errors));

        return Ok(ResponseDto<object>.Success());
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginUserDto loginUserDto)
    {
        var result = await _authService.Login(loginUserDto);

        if (result.IsFailure)
            return BadRequest(ResponseDto<object>.Failure(result.Errors));

        return Ok(ResponseDto<object>.Success(result.Data));
    }

    [HttpPost("ResetPassword")]
    public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordDto resetPasswordDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ResponseDto<object>.Failure(ModelState.GetErrors()));
        }

        var resetPasswordResult = await _authService.ResetPasswordAsync(resetPasswordDto);

        if (resetPasswordResult.IsFailure)
            return BadRequest(ResponseDto<object>.Failure(resetPasswordResult.Errors));

        return Ok(ResponseDto<object>.Success(resetPasswordResult));
    }

    [HttpPost("ForgotPassword")]
    public async Task<IActionResult> ForgotPassword([FromBody] ResetPasswordDto resetPasswordDto)
    {
        var result = await _authService.ForgotPassword(resetPasswordDto);

        if (result.IsFailure)
            return BadRequest(ResponseDto<object>.Failure(result.Errors));

        return Ok(ResponseDto<object>.Success());
    }

    [HttpGet("ConfirmEmail")]
    public async Task<IActionResult> ConfirmEmail([FromQuery] string email, [FromQuery] string token)
    {
        var result = await _authService.ConfirmEmail(email, token);

        if (result.IsFailure)
            return BadRequest(ResponseDto<object>.Failure(result.Errors));

        return Ok(ResponseDto<object>.Success());
    }

    [HttpPost("ChangePassword")]
    public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDto changePasswordDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ResponseDto<object>.Failure(ModelState.GetErrors()));
        }
        var changePasswordResult = await _authService.ChangePasswordAsync(changePasswordDto);
        if (changePasswordResult.IsFailure)
            return BadRequest(ResponseDto<object>.Failure(changePasswordResult.Errors));

        return Ok(ResponseDto<object>.Success(changePasswordResult));
    }
}