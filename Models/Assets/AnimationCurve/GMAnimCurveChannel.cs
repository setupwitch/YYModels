namespace YYModels.Models;

/// <remarks>Version 0</remarks>
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
    public List<CurvePoint> Points { get; set; }

    /// <summary>
    /// whether the curve is visible in the editor.
    /// </summary>
    [GameMakerProperty("visible")]
    public bool IsVisible { get; set; }
}
