namespace YYModels.Models;

/// <summary>
/// The type of sprite image.
/// </summary>
public enum SpriteType
{
    /// <summary>
    /// A bitmap image.
    /// </summary>
    Bitmap = 0,
        
    /// <summary>
    /// An SWF vector image.
    /// </summary>
    SWF = 1,
        
    /// <summary>
    /// A Spine sprite for skeletal animation.
    /// </summary>
    Spine = 2,
        
    /// <summary>
    /// A vector image.
    /// </summary>
    Vector = 3,
}