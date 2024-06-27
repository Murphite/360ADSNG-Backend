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
        var user = await _userManager.FindByIdAsync(userId);

        if (user == null)
            return new Error[] { new("User.NotFound", "User Not Found") };

        var isVendor = await IsUserVendor(user);

        if (!isVendor)
            return new Error[] { new("User.NotVendor", "Only vendors can add billboards") };

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

        await _repository.Add(billboard);
        await _unitOfWork.SaveChangesAsync();

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
        var billboard = await _repository.GetAll<Billboard>()
        .Include(b => b.User)
        .FirstOrDefaultAsync(b => b.Id == billboardId);

        if (billboard is null)
            return new Error[] { new("Billboard.NotFound", "Billboard not found") };

        var billboardDetailsDto = new BillboardDetailsDto
        {
            BillboardName = billboard.Name,
            Location = billboard.Address?.ToString(),
            DailyImpressions = billboard.DailyImpressions,
            BoardType = billboard.BoardType,
            Price = billboard.Price,
            DurationPerDisplay = billboard.DurationPerDisplay,
            Time = billboard.Time,
            Dimension = billboard.Dimension,
            PixelSize = billboard.PixelSize,
            Orientation = billboard.Orientation,
            Negotiable = billboard.Negotiable,
            TrafficDescription = billboard.TrafficDescription,
            ImageUrl = billboard.ImageUrl,
            Note = billboard.Note
        };

        return Result<BillboardDetailsDto>.Success(billboardDetailsDto);
    }


    public async Task<Result> UpdateBillboard(string userId, UpdateBillboardDto Dto)
    {
        var user = await _userManager.FindByIdAsync(userId);

        if (user is null)
            return new Error[] { new("User.Error", "User Not Found") };

        var billboard = await _repository.GetAll<Billboard>()
            .FirstOrDefaultAsync(x => x.UserId == user.Id);

        if (billboard is null)
            return new Error[] { new("Billboards.Error", "Billboard Not Found") };

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

        _repository.Update(billboard);
        await _unitOfWork.SaveChangesAsync();

        return Result.Success();
    }

    public async Task<Result> DeleteBillboard(string userId, string billboardId)
    {
        var user = await _userManager.FindByIdAsync(userId);

        if (user == null)
            return new Error[] { new Error("User.NotFound", "User not found") };

        var billboard = await _repository.GetAll<Billboard>()
            .FirstOrDefaultAsync(x => x.UserId == user.Id && x.Id == billboardId);

        if (billboard == null)
            return new Error[] { new Error("Billboard.NotFound", "Billboard not found or not associated with the user") };

        _repository.Remove(billboard);
        await _unitOfWork.SaveChangesAsync();

        return Result.Success();
    }



    private async Task<bool> IsUserVendor(User user)
    {
        return await _repository.GetAll<Vendor>()
            .AnyAsync(v => v.UserId == user.Id);
    }
}
