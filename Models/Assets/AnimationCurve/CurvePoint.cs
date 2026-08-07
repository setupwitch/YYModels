namespace YYModels.Models;


public class CurvePoint
{
    /// <summary>
    /// The outgoing horizontal bezier handle of the point.
    /// </summary>
    [GameMakerProperty("th0")]
    public float CurveHorizontal0 { get; set; }

    /// <summary>
    /// The incoming horizontal bezier handle of the point.
    /// </summary>
    [GameMakerProperty("th1")]
    public float CurveHorizontal1 { get; set; }

    /// <summary>
    /// The outgoing vertical bezier handle of the point.
    /// </summary>
    [GameMakerProperty("tv0")]
    public float CurveVertical0 { get; set; }

    /// <summary>
    /// The incoming vertical bezier handle of the point.
    /// </summary>
    [GameMakerProperty("tv1")]
    public float CurveVertical1 { get; set; }

    /// <summary>
    /// The X position of the point.
    /// </summary>
    [GameMakerProperty("x")]
    public float X { get; set; }

    /// <summary>
    /// The Y position of the point.
    /// </summary>
    [GameMakerProperty("y")]
    public float Y { get; set; }
}