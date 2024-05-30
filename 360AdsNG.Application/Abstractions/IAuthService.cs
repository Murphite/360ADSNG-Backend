﻿using _360AdsNG.Application.Dtos;
using _360AdsNG.Application.Dtos.AuthDtos;

namespace _360AdsNG.Application.Abstractions;

public interface IAuthService
{
    public Task<Result> Register(RegisterUserDto registerUserDto);
    public Task<Result<LoginResponseDto>> Login(LoginUserDto loginUserDto);
    public Task<Result> ResetPasswordAsync(ResetPasswordDto resetPasswordDto);
    public Task<Result> ForgotPassword(ResetPasswordDto resetPasswordDto);
    public Task<Result> ConfirmEmail(string email, string token);
    public Task<Result> ChangePasswordAsync(ChangePasswordDto changePasswordDto);
    public Task<Result> VendorRegister(VendorRegisterDto registerVendorDto);
}