using _360AdsNG.Application.Dtos;
using _360AdsNG.Domain.Entities;
using _360AdsNG.Domain.Interfaces;
using _360AdsNG.Domain.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System.Web;
using _360AdsNG.Application.Abstractions;
using _360AdsNG.Domain.Constants;
using _360AdsNG.Application.Dtos.AuthDtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace _360AdsNG.Application.Services;

public class AuthService : IAuthService
{
    private readonly IJwtService _jwtService;
    private readonly UserManager<User> _userManager;
    private readonly IRepository _repository;
    private readonly IEmailService _emailService;
    private readonly IConfiguration _configuration;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<AuthService> _logger;


    public AuthService(UserManager<User> userManager, IRepository repository, IJwtService jwtService,
        IEmailService emailService, IConfiguration configuration, IUnitOfWork unitOfWork, ILogger<AuthService> logger)
    {
        _userManager = userManager;
        _repository = repository;
        _jwtService = jwtService;
        _emailService = emailService;
        _configuration = configuration;
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    public async Task<Result> Register(RegisterUserDto registerUserDto)
    {
        _logger.LogInformation($"*********** Attempting to {nameof(Register)}************");

        var user = new User
        {
            FirstName = registerUserDto.FirstName,
            LastName = registerUserDto.LastName,
            Email = registerUserDto.Email,
            PhoneNumber = registerUserDto.PhoneNumber,
            UserName = registerUserDto.Email,
            Password = registerUserDto.Password,
            ConfirmPassword = registerUserDto.ConfirmPassword,
            CreatedAt = DateTimeOffset.UtcNow,
            UpdatedAt = DateTimeOffset.UtcNow,
        };

       var result = await _userManager.CreateAsync(user, registerUserDto.Password);

        if (!result.Succeeded)
            return result.Errors.Select(error => new Error(error.Code, error.Description)).ToArray();

        result = await _userManager.AddToRoleAsync(user, RolesConstant.User);
        if (!result.Succeeded)
            return result.Errors.Select(error => new Error(error.Code, error.Description)).ToArray();

        return Result.Success();
    }

    public async Task<Result> RegisterBusiness(RegisterBusinessDto registerBusinessDto)
    {
        _logger.LogInformation($"*********** Attempting to {nameof(RegisterBusiness)}************");

        var emailExist = await _userManager.FindByEmailAsync(registerBusinessDto.BusinessEmail);

        if (emailExist != null)
            return new Error[] { new("Registration.Error", "Email already exists") };

        var user = new User
        {
            BusinessName = registerBusinessDto.BusinessName,
            ContactName = registerBusinessDto.ContactName,
            Email = registerBusinessDto.BusinessEmail,
            PhoneNumber = registerBusinessDto.PhoneNumber,
            UserName = registerBusinessDto.BusinessEmail,
            CreatedAt = DateTimeOffset.UtcNow,
            UpdatedAt = DateTimeOffset.UtcNow,
        };

        var result = await _userManager.CreateAsync(user, registerBusinessDto.Password);

        if (!result.Succeeded)
            return result.Errors.Select(error => new Error(error.Code, error.Description)).ToArray();

        result = await _userManager.AddToRoleAsync(user, RolesConstant.User);
        if (!result.Succeeded)
            return result.Errors.Select(error => new Error(error.Code, error.Description)).ToArray();

        return Result.Success();
    }

    public async Task<Result> RegisterVendor(VendorRegisterDto registerVendorDto)
    {
        _logger.LogInformation($"*********** Attempting to {nameof(RegisterVendor)}************");


        var emailExist = await _userManager.FindByEmailAsync(registerVendorDto.Email);
        if (emailExist != null)
            return Result.Failure(new Error[] { new Error("Registration.Error", "Email already exists") });

        var user = new User
        {
            UserName = registerVendorDto.Email,
            Email = registerVendorDto.Email,
            FirstName = registerVendorDto.FirstName,
            LastName = registerVendorDto.LastName,
            PhoneNumber = registerVendorDto.PhoneNumber,
            CreatedAt = DateTimeOffset.UtcNow,
            UpdatedAt = DateTimeOffset.UtcNow
        };

        var result = await _userManager.CreateAsync(user, registerVendorDto.Password);
        if (!result.Succeeded)
            return Result.Failure(result.Errors.Select(error => new Error(error.Code, error.Description)).ToArray());

        var vendor = new Vendor
        {
            UserId = user.Id,
            VendorType = registerVendorDto.VendorType,
            CreatedAt = DateTimeOffset.UtcNow,
            UpdatedAt = DateTimeOffset.UtcNow
        };

        await _repository.Add(vendor);
        await _unitOfWork.SaveChangesAsync();

        result = await _userManager.AddToRoleAsync(user, RolesConstant.Vendor);
        if (!result.Succeeded)
            return Result.Failure(result.Errors.Select(error => new Error(error.Code, error.Description)).ToArray());

        var confirmEmailUrl = _configuration["ConfirmEmailUrl"];
        var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        var encodedEmail = HttpUtility.UrlEncode(user.Email);
        var encodedToken = HttpUtility.UrlEncode(token);
        var confirmationLink = $"{confirmEmailUrl}?email={encodedEmail}&token={encodedToken}";
        var body = @$"Hi {user.FirstName}, Please click the link <a href='{confirmationLink}'>here</a> to confirm your account's email";
        var emailResult = await _emailService.SendEmailAsync(user.Email, "Confirm Email", body);

        if (!emailResult)
            return Result.Failure(new Error[]
            {
            new Error("Registration.Error", "Account created but email verification failed.")
            });

        return Result.Success();
    }

    public async Task<Result> RegisterAdmin(AdminRegisterDto registerAdminDto)
    {
        _logger.LogInformation($"*********** Attempting to {nameof(RegisterAdmin)}************");

        var emailExist = await _userManager.FindByEmailAsync(registerAdminDto.Email);

        if (emailExist != null)
            return new Error[] { new("Registration.Error", "email already exist") };

        var user = new User
        {
            FirstName = registerAdminDto.FirstName,
            LastName = registerAdminDto.LastName,
            Email = registerAdminDto.Email,
            PhoneNumber = registerAdminDto.PhoneNumber,
            UserName = registerAdminDto.Email,
            Password = registerAdminDto.Password,
            ConfirmPassword = registerAdminDto.ConfirmPassword,
            CreatedAt = DateTimeOffset.UtcNow,
            UpdatedAt = DateTimeOffset.UtcNow,            
        };
        IdentityResult? result = null; 
        try
        {
             result = await _userManager.CreateAsync(user, registerAdminDto.Password);
            if (!result.Succeeded)
                return (result.Errors.Select(error => new Error(error.Code, error.Description)).ToArray());

            result = await _userManager.AddToRoleAsync(user, RolesConstant.Admin);
            if (!result.Succeeded)
                return result.Errors.Select(error => new Error(error.Code, error.Description)).ToArray();
        }
        catch (Exception ex)
        {
            return result.Errors.Select(error => new Error(error.Code, ex.Message)).ToArray();
        }
        

        var confirmEmailUrl = _configuration["ConfirmEmailUrl"];
        var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        var encodedEmail = HttpUtility.UrlEncode(user.Email);
        var encodedToken = HttpUtility.UrlEncode(token);
        var confirmationLink = $"{confirmEmailUrl}?email={encodedEmail}&token={encodedToken}";
        var body =
            @$"Hi {user.FirstName}, Please click the link <a href='{confirmationLink}'>here</a> to confirm your account's email";
        var emailResult = await _emailService.SendEmailAsync(user.Email, "Confirm Email", body);

        if (!emailResult)
            return new Error[]
            {
                new("Registration.Error",
                    "Account has been created successfully but error occured while sending verification email")
            };

        return Result.Success();
    }

    public async Task<Result<LoginResponseDto>> Login(LoginUserDto loginUserDto)
    {
        _logger.LogInformation($"*********** Attempting to {nameof(Login)}************");

        var user = await _userManager.FindByEmailAsync(loginUserDto.Email);

        if (user is null)
            return Result.Failure<LoginResponseDto>(new Error[] { new Error("Auth.Error", "Email or password not correct") });

        var isValidUser = await _userManager.CheckPasswordAsync(user, loginUserDto.Password);

        if (!isValidUser)
            return Result.Failure<LoginResponseDto>(new Error[] { new Error("Auth.Error", "Email or password not correct") });

        var roles = await _userManager.GetRolesAsync(user);
        var token = _jwtService.GenerateToken(user, roles);

        string? userId = user.Id;
        if (roles.Contains(RolesConstant.Vendor))
        {
            var vendor = await _repository.GetAll<Vendor>().FirstOrDefaultAsync(p => p.UserId == user.Id);
            if (vendor != null)
            {
                userId = vendor.Id;
            }
        }

        return Result.Success(new LoginResponseDto(token, roles.First(), userId));
    }

    public async Task<Result> ResetPasswordAsync(ResetPasswordDto resetPasswordDto)
    {
        _logger.LogInformation($"*********** Attempting to {nameof(ResetPasswordAsync)}************");

        var user = await _userManager.FindByEmailAsync(resetPasswordDto.Email);
        if (user is null)
            return new Error[] { new("Auth.Error", "No user found with the provided email") };

        var resetPasswordResult =
            await _userManager.ResetPasswordAsync(user, resetPasswordDto.Token, resetPasswordDto.NewPassword);

        if (!resetPasswordResult.Succeeded)
            return resetPasswordResult.Errors.Select(error => new Error(error.Code, error.Description)).ToArray();

        return Result.Success();
    }

    public async Task<Result> ForgotPassword(ResetPasswordDto resetPasswordDto)
    {
        _logger.LogInformation($"*********** Attempting to {nameof(ForgotPassword)}************");

        var user = await _userManager.FindByEmailAsync(resetPasswordDto.Email);

        if (user == null)
            return new Error[] { new("Auth.Error", "No user found with the provided email") };

        var token = await _userManager.GeneratePasswordResetTokenAsync(user);
        var resetLink =
            $"{_configuration["ResetPasswordUrl"]}?email={HttpUtility.UrlEncode(user.Email)}&token={HttpUtility.UrlEncode(token)}";

        const string emailSubject = "Your New Password";

        var emailBody = $"Hello {user.FirstName}, click this link to reset your password: {resetLink}.";

        var isSuccessful = await _emailService.SendEmailAsync(resetPasswordDto.Email, emailSubject, emailBody);
        if (!isSuccessful)
            return new Error[] { new("Auth.Error", "Error occured while sending reset password email") };

        return Result.Success();
    }

    public async Task<Result> ConfirmEmail(string email, string token)
    {
        _logger.LogInformation($"*********** Attempting to {nameof(ConfirmEmail)}************");

        var user = await _userManager.FindByEmailAsync(email);

        if (user is null)
            return new Error[] { new("Auth.Error", "User not found") };

        var confirmEmailResult = await _userManager.ConfirmEmailAsync(user, token);

        if (!confirmEmailResult.Succeeded)
        {
            return Result.Failure(confirmEmailResult.Errors.Select(e => new Error(e.Code, e.Description)).ToArray());
        }

        user.EmailConfirmed = true;

        var updateResult = await _userManager.UpdateAsync(user);

        if (!updateResult.Succeeded)
        {
            return Result.Failure(updateResult.Errors.Select(e => new Error(e.Code, e.Description)).ToArray());
        }

        return Result.Success();
    }

    public async Task<Result> ChangePasswordAsync(ChangePasswordDto model)
    {
        _logger.LogInformation($"*********** Attempting to {nameof(ChangePasswordAsync)} ************");

        var user = await _userManager.FindByEmailAsync(model.Email);

        if (user == null)
            return new Error[] { new("Auth.Error", "email not correct") };

        if (!await _userManager.CheckPasswordAsync(user, model.OldPassword))
            return new Error[] { new("Auth.Error", "password not correct") };

        if (model.NewPassword != model.ConfirmPassword)
            return new Error[] { new("Auth.Error", "Newpassword and Confirmpassword must match") };

        var result = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
        if (!result.Succeeded)
            return result.Errors.Select(error => new Error(error.Code, error.Description)).ToArray();

        return Result.Success();

    }

    
}