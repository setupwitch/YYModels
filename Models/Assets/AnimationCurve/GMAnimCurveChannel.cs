namespace YYModels.Models;

[YYVersion(0)]
public class GMAnimCurveChannel : ResourceBase
{
    /// <summary>
    /// the color of the channel.
    /// </summary>
    [GameMakerProperty("colour")]
    public uint Color { get; set; }

    /// <summary>
    /// the points in the animation curve.
    /// </summary>
    [GameMakerProperty("points")]
    public List<CurvePoint> Points { get; set; } = new();

    /// <summary>
    /// whether the curve is visible in the editor.
    /// </summary>
    [GameMakerProperty("visible")]
    public bool IsVisible { get; set; }
}
