namespace YYModels.Models;

/// <summary>
/// A layer designed for path assets.
/// </summary>
/// <remarks>Version 0</remarks>
public class GMRPathLayer : GMRLayer
{
    /// <summary>
    /// The color of the path?
    /// </summary>
    [GameMakerProperty("colour")]
    public uint Color { get; set; }

    /// <summary>
    /// A reference to the path.
    /// </summary>
    [GameMakerProperty("pathId")]
    public ResourceReference<GMPath>? Path { get; set; }
}