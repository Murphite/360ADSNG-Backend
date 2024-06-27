namespace _360AdsNG.Domain.Enums;

public class PixelSize
{
    public int Width { get; set; }
    public int Height { get; set; }

    public PixelSize(int width, int height)
    {
        Width = width;
        Height = height;
    }

    // method to return a formatted string
    public override string ToString()
    {
        return $"{Width}x{Height}";
    }
}

