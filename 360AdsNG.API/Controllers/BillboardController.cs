using _360AdsNG.API.Dtos;
using _360AdsNG.Application.Abstractions;
using _360AdsNG.Application.Dtos;
using _360AdsNG.Application.Dtos.BillboardDtos;
using _360AdsNG.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace _360AdsNG.API.Controllers;

[ApiController]
[Route("api/billboard")]
public class BillboardController : Controller
{
    private readonly IBillboardService _billboardService;
    private readonly ILogger<BillboardController> _logger;
    private readonly UserManager<User> _userManager;

    public BillboardController(IBillboardService billboardService, ILogger<BillboardController> logger, UserManager<User> userManager)
    {
        _billboardService = billboardService;
        _logger = logger;
        _userManager = userManager;
    }

    [HttpPost("CreateNewBillboard")]
    public async Task<IActionResult> CreateNewBillboard([FromBody] CreateBillboardDto billboardDto)
    {
        var userId = GetUserId();
        var response = await _billboardService.CreateBillboard(userId, billboardDto);
        if (response.IsFailure)
        {
            return BadRequest(ResponseDto<object>.Failure(response.Errors));
        }

        return Ok(ResponseDto<object>.Success());
    }

    [HttpGet("GetAllBillboard")]
    public async Task<IActionResult> GetAllBillboard([FromQuery] PaginationFilter? paginationFilter)
    {
        paginationFilter ??= new PaginationFilter();
        var result = await _billboardService.GetAllBillboards(paginationFilter);

        if (result.IsFailure)
            return BadRequest(ResponseDto<object>.Failure(result.Errors));

        return Ok(ResponseDto<object>.Success(result.Data));
    }

    [HttpGet("GetBillboardDetails{billboardId}")]
    public async Task<IActionResult> GetBillboardDetails([FromRoute] string billboardId)
    {
        var result = await _billboardService.GetBillboardDetails(billboardId);
        if (result.IsFailure)
            return BadRequest(ResponseDto<object>.Failure(result.Errors));

        return Ok(ResponseDto<object>.Success(result.Data));
    }

    [HttpPut("UpdateBillboard")]
    public async Task<IActionResult> UpdateBillboard([FromBody] UpdateBillboardDto dto)
    {
        var userId = _userManager.GetUserId(User);
        var result = await _billboardService.UpdateBillboard(userId!, dto);
        if (result.IsFailure)
            return BadRequest(ResponseDto<object>.Failure(result.Errors));

        return Ok(ResponseDto<object>.Success());
    }

    [HttpDelete("DeleteBy{billboardId}")]
    public async Task<IActionResult> DeleteBillboard(string billboardId)
    {
        var userId = _userManager.GetUserId(User);
        var result = await _billboardService.DeleteBillboard(billboardId, userId!);
        if (result.IsFailure)
            return BadRequest(ResponseDto<object>.Failure(result.Errors));

        return Ok(ResponseDto<object>.Success());
    }

    private string GetUserId()
    {
        return _userManager.GetUserId(User)!;
    }
}
