namespace _360AdsNG.Application.Dtos.AuthDtos;

//public record LoginResponseDto(string Token, string Role, string? VendorId);

public class LoginResponseDto
{
    public string Token { get; }
    public string Role { get; }
    public string Id { get; }

    public LoginResponseDto(string token, string role, string id)
    {
        Token = token;
        Role = role;
        Id = id;
    }
}
