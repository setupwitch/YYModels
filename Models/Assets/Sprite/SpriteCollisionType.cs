namespace YYModels.Models;

/// <summary>
/// The collision type of the sprite, chooses how the collision mask is generated.
/// </summary>
public enum SpriteCollisionType
{
    /// <summary>
    /// Precise for the first frame.
    /// </summary>
    Precise,
        
    /// <summary>
    /// A rectangle.
    /// </summary>
    Rectangle,
        
    /// <summary>
    /// A circular shape.
    /// </summary>
    Ellipse,
        
    /// <summary>
    /// A diamond shape.
    /// </summary>
    Diamond,
        
    /// <summary>
    /// Same as <see cref="Precise"/> except for each frame of the sprite.
    /// </summary>
    PerFrame,
        
    /// <summary>
    /// A rectangle that supports rotation.
    /// </summary>
    RotatedRectangle,
        
    /// <summary>
    /// Collision for a Spine sprite.
    /// </summary>
    Spine,
}