using _360AdsNG.Application.Dtos;
using _360AdsNG.Application.Dtos.BillboardDtos;

namespace _360AdsNG.Application.Abstractions;

public interface IBillboardService
{
    Task<Result> CreateBillboard(string userId, CreateBillboardDto billboardDto);
    Task<Result<PaginatorDto<IEnumerable<ListBillboardDto>>>> GetAllBillboards(PaginationFilter paginationFilter);
    Task<Result<BillboardDetailsDto>> GetBillboardDetails(string billboardId);
    Task<Result> UpdateBillboard(string userId, UpdateBillboardDto Dto);
    Task<Result> DeleteBillboard(string userId, string billboardId);
}
