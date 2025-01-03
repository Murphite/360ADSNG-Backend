﻿using System.ComponentModel.DataAnnotations;

namespace _360AdsNG.Application.Dtos.AuthDtos;

public record LoginUserDto
{
    [Required] public string Email { get; set; }

    [Required] public string Password { get; set; }
}
