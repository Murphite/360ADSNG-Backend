using _360AdsNG.Domain.Enums;

namespace _360AdsNG.Application.Dtos.BillboardDtos;

public class BillboardDetailsDto
{
    public string BillboardName { get; set; }
    public string? Location { get; set; }
    public int DailyImpressions { get; set; }
    public string BoardType { get; set; }
    public int Price { get; set; }
    public int DurationPerDisplay { get; set; }
    public string Time { get; set; }
    public string Dimension { get; set; }
    public string PixelSize { get; set; }
    public OrientationType Orientation { get; set; }
    public NegotiableType Negotiable { get; set; }
    public string TrafficDescription { get; set; }
    public string ImageUrl { get; set; }
    public string Note { get; set; }
}
