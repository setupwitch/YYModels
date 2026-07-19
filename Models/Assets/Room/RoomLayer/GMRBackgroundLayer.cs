namespace YYModels.Models;

/// <summary>
/// A Background layer in a room.
/// </summary>
/// <remarks>Version 0</remarks>
public class GMRBackgroundLayer : GMRLayer
{
    /// <summary>
    /// The animation speed of the background sprite.
    /// </summary>
    [GameMakerProperty("animationFPS")]
    public float FramesPerSecond { get; set; }

    /// <summary>
    /// The <see cref="TimeUnits"/> to use when animating the background sprite.
    /// </summary>
    [GameMakerProperty("animationSpeedType")]
    public TimeUnits AnimationSpeedUnits { get; set; }

    /// <summary>
    /// The color tint of the background sprite.
    /// </summary>
    [GameMakerProperty("colour")]
    public uint Color { get; set; }

    /// <summary>
    /// The amount of pixels the background will be moved right every frame.
    /// </summary>
    [GameMakerProperty("hspeed")]
    public float HorizontalSpeed { get; set; }

    /// <summary>
    /// Whether the background is horizontally tiled.
    /// </summary>
    [GameMakerProperty("htiled")]
    public bool TileHorizontally { get; set; }

    /// <summary>
    /// A reference to the background sprite.
    /// </summary>
    [GameMakerProperty("spriteId")]
    public ResourceReference<GMSprite>? Sprite { get; set; }

    /// <summary>
    /// Whether to stretch the sprite to fit the room.
    /// </summary>
    [GameMakerProperty("stretch")]
    public bool IsStretched { get; set; }

    /// <summary>
    /// Whether the <see cref="FramesPerSecond"/> is defined by the user.
    /// </summary>
    [GameMakerProperty("userdefinedAnimFPS")]
    public bool HasCustomAnimationSpeed { get; set; }

    /// <summary>
    /// The amount of pixels the background will be moved down every frame.
    /// </summary>
    [GameMakerProperty("vspeed")]
    public float VerticalSpeed { get; set; }

    /// <summary>
    /// Whether the background is veritcally tiled.
    /// </summary>
    [GameMakerProperty("vtiled")]
    public bool TileVertically { get; set; }

    /// <summary>
    /// The X offset of the background.
    /// </summary>
    [GameMakerProperty("x")]
    public int X { get; set; }

    /// <summary>
    /// The Y offset of the background.
    /// </summary>
    [GameMakerProperty("y")]
    public int Y { get; set; }
    
}