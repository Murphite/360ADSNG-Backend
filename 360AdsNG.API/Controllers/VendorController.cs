using _360AdsNG.API.Dtos;
using _360AdsNG.Application.Abstractions;
using _360AdsNG.Application.Dtos.VendorDtos;
using _360AdsNG.Application.Services;
using _360AdsNG.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace _360AdsNG.API.Controllers;

[ApiController]
//[Authorize]
[Route("api/v1/vendor")]
public class VendorController : Controller
{
    private readonly IVendorService _vendorService;
    private readonly UserManager<User> _userManager;
    private readonly ILogger<VendorController> _logger;

    public VendorController(IVendorService vendorService, UserManager<User> userManager, ILogger<VendorController> logger)
    {
        _vendorService = vendorService;
        _userManager = userManager;
        _logger = logger;
    }

    [HttpPut]
    public async Task<IActionResult> UpdateVendorProfile([FromBody] UpdateVendorProfileDto dto)
    {
        var userId = _userManager.GetUserId(User);
        var result = await _vendorService.UpdateVendorProfile(dto, userId!);

        if (result.IsFailure)
            return BadRequest(ResponseDto<object>.Failure(result.Errors));

        return Ok(ResponseDto<object>.Success());
    }
}
