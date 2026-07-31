namespace YYModels.Models;
[YYVersion(2)]
public class GMShape : ResourceBase
{
    /// <summary>
    /// Unknown, possibly when a shape is rasterized?
    /// </summary>
    [GameMakerProperty("baked")]
    public bool IsBaked { get; set; }

    /// <summary>
    /// Unknown, possibly deletes the triangles that are obscured by others?
    /// </summary>
    [GameMakerProperty("hiddenGeometryClipped")]
    public bool HiddenGeometryIsClipped { get; set; }

    /// <summary>
    /// The maximum width of the shape.
    /// </summary>
    [GameMakerProperty("maxX")]
    public float MaxX { get; set; }

    /// <summary>
    /// The maximum height of the shape.
    /// </summary>
    [GameMakerProperty("maxY")]
    public float MaxY { get; set; }

    /// <summary>
    /// The minimum width of the shape.
    /// </summary>
    [GameMakerProperty("minX")]
    public float MinX { get; set; }

    /// <summary>
    /// The minimum height of the shape.
    /// </summary>
    [GameMakerProperty("minY")]
    public float MinY { get; set; }

    /// <summary>
    /// How precise the shape is, determines how many triangles are generated.
    /// </summary>
    [GameMakerProperty("precision")]
    public float Precision { get; set; }

    /// <summary>
    /// The style groups in the shape.
    /// </summary>
    [GameMakerProperty("styleGroups")]
    public List<GMStyleGroup> StyleGroups { get; set; } = new();

    [GameMakerProperty("triangulated")]
    public bool IsTriangulated { get; set; }
}
