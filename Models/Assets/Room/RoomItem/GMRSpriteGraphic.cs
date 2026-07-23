namespace YYModels.Models;

/// <summary>
/// A sprite graphic in a <see cref="GMRAssetLayer"/>.
/// </summary>
[YYVersion(1)]
public class GMRSpriteGraphic : GMRItem
{
    /// <summary>
    /// The animation speed of the graphic.
    /// </summary>
    [GameMakerProperty("animationSpeed")]
    public float ImageSpeed { get; set; }

    /// <summary>
    /// The color of the graphic.
    /// </summary>
    [GameMakerProperty("colour")]
    public uint Color { get; set; }

    /// <summary>
    /// The start frame of the sprite.
    /// </summary>
    [GameMakerProperty("headPosition")]
    public float ImageIndex { get; set; }

    /// <summary>
    /// The rotation of the graphic.
    /// </summary>
    [GameMakerProperty("rotation")]
    public float Rotation { get; set; }

    /// <summary>
    /// The X scale of the graphic.
    /// </summary>
    [GameMakerProperty("scaleX")]
    public float ScaleX { get; set; }

    /// <summary>
    /// The Y scale of the graphic.
    /// </summary>
    [GameMakerProperty("scaleY")]
    public float ScaleY { get; set; }

    /// <summary>
    /// A reference to the sprite.
    /// </summary>
    [GameMakerProperty("spriteId")]
    public ResourceReference<GMSprite>? Sprite { get; set; }
        
}