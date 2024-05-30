using _360AdsNG.Application.Abstractions;
using _360AdsNG.Application.Dtos;
using _360AdsNG.Application.Dtos.BillboardDtos;
using _360AdsNG.Application.Utilities;
using _360AdsNG.Domain.Entities;
using _360AdsNG.Domain.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace _360AdsNG.Application.Services;

public class BillboardService : IBillboardService
{
    private readonly IRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly UserManager<User> _userManager;

    public BillboardService(IRepository repository, IUnitOfWork unitOfWork,UserManager<User> userManager)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _userManager = userManager;
    }

    
    public async Task<Result> CreateBillboard(string userId, CreateBillboardDto billboardDto)
    {
        // Find the user by ID
        var user = await _userManager.FindByIdAsync(userId);

        // If the user is not found, return an error
        if (user == null)
            return new Error[] { new("User.NotFound", "User Not Found") };

        // Check if the user is a vendor
        var isVendor = await IsUserVendor(user);

        // If the user is not a vendor, return an error
        if (!isVendor)
            return new Error[] { new("User.NotVendor", "Only vendors can add billboards") };

        // Create the billboard object
        var billboard = new Billboard
        {
            Name = billboardDto.BillboardName,
            Price = billboardDto.Price,
            AddressId = billboardDto.Location,
            BoardType = billboardDto.BoardType,
            DailyImpressions = billboardDto.DailyImpressions,
            DurationPerDisplay = billboardDto.DurationPerDisplay,
            Time = billboardDto.Time,
            Dimension = billboardDto.Dimension.ToString(),
            PixelSize = billboardDto.PixelSize.ToString(),
            Orientation = billboardDto.Orientation,
            Negotiable = billboardDto.Negotiable,
            TrafficDescription = billboardDto.TrafficDescription,
            ImageUrl = billboardDto.ImageUrl,
            CreatedAt = DateTimeOffset.UtcNow,
            UpdatedAt = DateTimeOffset.UtcNow,
        };

        // Add the billboard to the repository and save changes
        await _repository.Add(billboard);
        await _unitOfWork.SaveChangesAsync();

        // Return success result
        return Result.Success();
    }
        
    public async Task<Result<PaginatorDto<IEnumerable<ListBillboardDto>>>> GetAllBillboards(PaginationFilter paginationFilter)
    {
        var billboards = await _repository.GetAll<Billboard>()
            .Select(billboard => new ListBillboardDto
            {
                BillboardId = billboard.Id,
                BillboardName = billboard.Name,
                Location = billboard.AddressId,
                DailyImpressions = billboard.DailyImpressions,
                BoardType = billboard.BoardType,
                Time = billboard.Time,
                Price = billboard.Price,
                ImageUrl = billboard.ImageUrl,
            })
            .Paginate(paginationFilter);

        return billboards;
    }

    public async Task<Result<BillboardDetailsDto>> GetBillboardDetails(string billboardId)
    {
        // Find the billboard including the associated user
        var billboard = await _repository.GetAll<Billboard>()
        .Include(b => b.User)
        .FirstOrDefaultAsync(b => b.Id == billboardId);

        if (billboard is null)
            return new Error[] { new("Billboard.NotFound", "Billboard not found") };

        return new BillboardDetailsDto();
    }

    public async Task<Result> UpdateBillboard(string userId, UpdateBillboardDto Dto)
    {
        var user = await _userManager.FindByIdAsync(userId);

        if (user is null)
            return new Error[] { new("User.Error", "User Not Found") };

        // Retrieve the billboard associated with the user
        var billboard = await _repository.GetAll<Billboard>()
            .FirstOrDefaultAsync(x => x.UserId == user.Id);

        if (billboard is null)
            return new Error[] { new("Billboards.Error", "Billboard Not Found") };

        // Update the billboard properties with the DTO values
        billboard.Name = Dto.BillboardName ?? billboard.Name;
        billboard.Price = Dto.Price ?? billboard.Price;
        billboard.TrafficDescription = Dto.TrafficDescription ?? billboard.TrafficDescription;
        billboard.DurationPerDisplay = Dto.DurationPerDisplay ?? billboard.DurationPerDisplay;
        billboard.BoardType = Dto.BoardType ?? billboard.BoardType;
        billboard.AddressId = Dto.Location ?? billboard.AddressId;
        billboard.Orientation = Dto.Orientation ?? billboard.Orientation;
        billboard.DailyImpressions = Dto.DailyImpressions ?? billboard.DailyImpressions;
        billboard.DurationPerDisplay = Dto.DurationPerDisplay ?? billboard.DurationPerDisplay;
        billboard.Time = Dto.Time ?? billboard.Time;
        billboard.Dimension = Dto.Dimension.ToString() ?? billboard.Dimension.ToString();
        billboard.PixelSize = Dto.PixelSize.ToString() ?? billboard.PixelSize.ToString();
        billboard.Negotiable = Dto.Negotiable ?? billboard.Negotiable;
        billboard.ImageUrl = Dto.ImageUrl ?? billboard.ImageUrl;

        // Update the billboard in the repository and save changes
        _repository.Update(billboard);
        await _unitOfWork.SaveChangesAsync();

        return Result.Success();
    }

    public async Task<Result> DeleteBillboard(string userId, string billboardId)
    {
        // Find the user by ID
        var user = await _userManager.FindByIdAsync(userId);

        // If the user is not found, return an error
        if (user == null)
            return new Error[] { new Error("User.NotFound", "User not found") };

        // Retrieve the billboard associated with the user
        var billboard = await _repository.GetAll<Billboard>()
            .FirstOrDefaultAsync(x => x.UserId == user.Id && x.Id == billboardId);

        // If the billboard is not found or not associated with the user, return an error
        if (billboard == null)
            return new Error[] { new Error("Billboard.NotFound", "Billboard not found or not associated with the user") };

        // Remove the billboard from the repository
        _repository.Remove(billboard);
        await _unitOfWork.SaveChangesAsync();

        // Return success result
        return Result.Success();
    }



    // Helper method to check if the user is a vendor
    private async Task<bool> IsUserVendor(User user)
    {
        return await _repository.GetAll<Vendor>()
            .AnyAsync(v => v.UserId == user.Id);
    }
}
