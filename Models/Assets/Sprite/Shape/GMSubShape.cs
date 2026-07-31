namespace YYModels.Models;

[YYVersion(2)]
public class GMSubShape : ResourceBase
{
    /// <summary>
    /// The index of the lines in the subshape with antialiasing.
    /// </summary>
    [GameMakerProperty("AALines")]
    public List<int> AntiAliasingLines { get; set; } = new();

    /// <summary>
    /// Directional vectors in the subshape that use antialiasing.
    /// </summary>
    [GameMakerProperty("AAVectors")]
    public List<Point> AntiAliasingVectors { get; set; } = new();

    /// <summary>
    /// Whether the subshape goes back around to its starting point.
    /// </summary>
    /// <remarks>Whenever I try to change this, it resets itself back to true.</remarks>
    [GameMakerProperty("closed")]
    public bool IsClosed { get; set; }

    /// <inheritdoc cref="FillStyle1"/>
    /// <remarks>Always -1?</remarks>
    [GameMakerProperty("fillStyle0")]
    public int FillStyle0 { get; set; }

    /// <summary>
    /// The index of the fill style in <see cref="GMStyleGroup.FillStyles"/>.
    /// </summary>
    [GameMakerProperty("fillStyle1")]
    public int FillStyle1 { get; set; }

    /// <summary>
    /// Unknown, Unused?.
    /// </summary>
    [GameMakerProperty("linePoints")]
    public List<Point> LinePoints { get; set; } = new();

    /// <summary>
    /// The index of the line style in <see cref="GMStyleGroup.LineStyleData"/>.
    /// </summary>
    [GameMakerProperty("lineStyle")]
    public int LineStyle { get; set; }

    /// <summary>
    /// Unknown, Unused?.
    /// </summary>
    [GameMakerProperty("lineTris")]
    public List<int> LineTris { get; set; } = new();

    /// <summary>
    /// The lines in the subshape.
    /// </summary>
    [GameMakerProperty("lines")]
    public List<int> Lines { get; set; } = new();

    /// <summary>
    /// The color of each point in the subshape.
    /// </summary>
    [GameMakerProperty("pointColours")]
    public List<uint> PointColours { get; set; } = new();

    /// <summary>
    /// The points in the subshape
    /// </summary>
    [GameMakerProperty("points")]
    public List<Point> Points { get; set; } = new();

    /// <summary>
    /// The index of the <see cref="Points"/> in the subshape.
    /// </summary>
    [GameMakerProperty("tris")]
    public List<int> Tris { get; set; } = new();
}
