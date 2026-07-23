namespace YYModels.Models;


/// <summary>
/// A graphic in a <see cref="GMRAssetLayer"/>, used for legacy tiles?
/// </summary>
[YYVersion(1)]
public class GMRGraphic : GMRItem
{        
    /// <summary>
    /// The color of the tile.
    /// </summary>
    [GameMakerProperty("colour")]
    public uint Color { get; set; }

    /// <summary>
    /// The height of the graphic.
    /// </summary>
    [GameMakerProperty("h")]
    public int Height { get; set; }

    /// <inheritdoc cref="GMRSpriteGraphic.Sprite"/>
    [GameMakerProperty("spriteId")]
    public ResourceReference<GMSprite>? Sprite { get; set; }

    /// <summary>
    /// The X position of the tile
    /// </summary>
    [GameMakerProperty("u0")]
    public int SourceX1 { get; set; }

    /// <summary>
    /// The end point of the tile horizontally.
    /// </summary>
    /// <example><see cref="SourceX1"/> + <see cref="Width"/> == <see cref="SourceX2"/></example>
    [GameMakerProperty("u1")]
    public int SourceX2 { get; set; }

    /// <summary>
    /// The Y position of the tile
    /// </summary>
    [GameMakerProperty("v0")]
    public int SourceY1 { get; set; }

    /// <summary>
    /// The end point of the tile vertically.
    /// </summary>
    /// <example><see cref="SourceY1"/> + <see cref="Height"/> == <see cref="SourceY2"/></example>
    [GameMakerProperty("v1")]
    public int SourceY2 { get; set; }

    /// <summary>
    /// The width of the graphic.
    /// </summary>
    [GameMakerProperty("w")]
    public int Width { get; set; }
    
}

