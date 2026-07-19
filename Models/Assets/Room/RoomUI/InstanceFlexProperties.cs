namespace YYModels.Models;


/// <summary>
/// Transformation data for an item.
/// </summary>
public class FlexProperties
{
    /// <summary>
    /// The <see cref="Origin"/> of the item.
    /// </summary>
    [GameMakerProperty("anchor")]
    public Origin Anchor { get; set; }

    /// <summary>
    /// Whether to keep the aspect ratio of the sprite.
    /// </summary>
    [GameMakerProperty("keepAspect")]
    public bool KeepAspectRatio { get; set; }

    /// <summary>
    /// The height of the item.
    /// </summary>
    [GameMakerProperty("stretchHeight")]
    public bool Height { get; set; }

    /// <summary>
    /// The width of the item.
    /// </summary>
    [GameMakerProperty("stretchWidth")]
    public bool Width { get; set; }

    /// <summary>
    /// Whether to tile horizontally.
    /// </summary>
    [GameMakerProperty("tileH")]
    public bool TileHorizontally { get; set; }

    /// <summary>
    /// Whether to tile vertically.
    /// </summary>
    [GameMakerProperty("tileV")]
    public bool TileVertically { get; set; }
}