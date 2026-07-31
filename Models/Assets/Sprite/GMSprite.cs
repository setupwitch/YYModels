namespace YYModels.Models;

[YYVersion(2)]
[GMResource("sprites")]
public class GMSprite : ResourceBase
{
    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("DynamicTexturePage")]
    public bool DynamicTexturePage { get; set; }

    /// <summary>
    /// Whether to give the sprite a seperate texture page
    /// </summary>
    [GameMakerProperty("For3D")]
    public bool SeperateTexturePage { get; set; }

    /// <summary>
    /// Whether to horizontally tile the sprite.
    /// </summary>
    [GameMakerProperty("HTile")]
    public bool TileHorizontally { get; set; }

    /// <summary>
    /// Whether to vertically tile the sprite.
    /// </summary>
    [GameMakerProperty("VTile")]
    public bool TileVertically { get; set; }

    /// <summary>
    /// The bounding box mode of the sprite, see <see cref="SpriteBoundingBoxMode"/>.
    /// </summary>
    [GameMakerProperty("bboxMode")]
    public SpriteBoundingBoxMode BBoxMode { get; set; }

    /// <summary>
    /// The bottom bounding box of the sprite.
    /// </summary>
    [GameMakerProperty("bbox_bottom")]
    public int BBoxBottom { get; set; }

    /// <summary>
    /// The left bounding box of the sprite.
    /// </summary>
    [GameMakerProperty("bbox_left")]
    public int BBoxLeft { get; set; }

    /// <summary>
    /// The right bounding box of the sprite.
    /// </summary>
    [GameMakerProperty("bbox_right")]
    public int BBoxRight { get; set; }

    /// <summary>
    /// The top bounding box of the sprite.
    /// </summary>
    [GameMakerProperty("bbox_top")]
    public int BBoxTop { get; set; }

    /// <summary>
    /// The collision shape/kind of the sprite, see <see cref="SpriteCollisionType"/>.
    /// </summary>
    [GameMakerProperty("collisionKind")]
    public SpriteCollisionType CollisionType { get; set; }

    /// <summary>
    /// The tolerance of the collision mapping, important for collision mask generation. 
    /// </summary>
    [GameMakerProperty("collisionTolerance")]
    public uint CollisionMaskTolerance { get; set; }

    /// <summary>
    /// Whether the sprite has filtering enabled.
    /// </summary>
    [GameMakerProperty("edgeFiltering")]
    public bool SmoothFilter { get; set; }

    /// <summary>
    /// The frames that the sprite has.
    /// </summary>
    [GameMakerProperty("frames")]
    public List<GMSpriteFrame> Frames { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("gridX")]
    public int GridX { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("gridY")]
    public int GridY { get; set; }

    /// <summary>
    /// The height of the sprite.
    /// </summary>
    [GameMakerProperty("height")]
    public int Height { get; set; }

    /// <summary>
    /// The layers of the sprite.
    /// </summary>
    [GameMakerProperty("layers")]
    public List<GMImageLayer> Layers { get; set; }

    /// <summary>
    /// The Nine Slice data of the sprite.
    /// </summary>
    [GameMakerProperty("nineSlice")]
    public GMNineSliceData? NineSlice { get; set; }

    /// <summary>
    /// The sprite origin.
    /// </summary>
    [GameMakerProperty("origin")]
    public Origin OriginType { get; set; }

    /// <summary>
    /// Whether the sprite has transparency? TODO: research more
    /// </summary>
    [GameMakerProperty("preMultiplyAlpha")]
    public bool IsTransparent { get; set; }

    /// <summary>
    /// The embedded sequence in the sprite.
    /// </summary>
    [GameMakerProperty("sequence")]
    public GMSequence EmbeddedSequence { get; set; }

    /// <summary>
    /// The colors in the sprite editor.
    /// </summary>
    [GameMakerProperty("swatchColours")]
    public uint[]? EditorColors { get; set; }

    /// <summary>
    /// The precision of the SWF vector, the higher the more accurate.
    /// </summary>
    [GameMakerProperty("swfPrecision")]
    public float SWFPrecision { get; set; }

    /// <summary>
    /// The texture group of the sprite.
    /// </summary>
    [GameMakerProperty("textureGroupId")]
    public ResourceReference<GMTextureGroup> TextureGroup { get; set; }

    /// <summary>
    /// The type of the sprite, see <see cref="SpriteType"/>.
    /// </summary>
    [GameMakerProperty("type")]
    public SpriteType Type { get; set; }

    /// <summary>
    /// The width of the sprite.
    /// </summary>
    [GameMakerProperty("width")]
    public int Width { get; set; }
}
