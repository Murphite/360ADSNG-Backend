

using _360AdsNG.Domain.Entities;
using _360AdsNG.Domain.Enums;

namespace _360AdsNG.Application.Dtos.BillboardDtos;

public class CreateBillboardDto
{
    public string BillboardId { get; set; }
    public string BillboardName { get; set; }
    public int Price { get; set; }
    public string Location { get; set; }
    public string BoardType { get; set; }
    public int DailyImpressions { get; set; }
    public int DurationPerDisplay { get; set; }
    public string Time { get; set; }
    public Dimension Dimension { get; set; }
    public PixelSize PixelSize { get; set; }
    public OrientationType Orientation { get; set; }
    public NegotiableType Negotiable { get; set; }
    public string TrafficDescription { get; set; }
    public string ImageUrl { get; set; }
}
