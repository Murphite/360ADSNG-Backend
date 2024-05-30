using _360AdsNG.Domain.Enums;

namespace _360AdsNG.Application.Dtos.BillboardDtos;

public class ListBillboardDto
{
    public string BillboardId { get; set; }
    public string BillboardName { get; set; }
    public string Location { get; set; }
    public int DailyImpressions { get; set; }
    public string BoardType { get; set; }
    public NegotiableType NegotiableType { get; set; }
    public string ImageUrl { get; set; }
    public int Price { get; set; }
    public string Time { get; set; }
}
