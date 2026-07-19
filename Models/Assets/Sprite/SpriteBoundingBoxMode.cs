namespace YYModels.Models;

/// <summary>
/// The bounding box mode of the sprite.
/// </summary>
public enum SpriteBoundingBoxMode
{
    /// <summary>
    /// Automatically.
    /// </summary>
    Auto,
        
    /// <summary>
    /// The full image.
    /// </summary>
    Full,
        
    /// <summary>
    /// Manually choose the bounding box.
    /// </summary>
    Manual,
}