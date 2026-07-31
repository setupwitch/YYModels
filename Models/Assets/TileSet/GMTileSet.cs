namespace YYModels.Models;

[YYVersion(1)]
[GMResource("tilesets")]
public class GMTileSet : ResourceBase
{
    /// <summary>
    /// The AutoTilesets of the tileset.
    /// </summary>
    [GameMakerProperty("autoTileSets")]
    public List<GMAutoTileSet> AutoTileSets { get; set; } = new();

    /// <summary>
    /// Custom tile brushes.
    /// </summary>
    [GameMakerProperty("macroPageTiles")]
    public TileMap MacroPageTiles { get; set; }

    /// <summary>
    /// The amount of columns in the tileset.
    /// </summary>
    [GameMakerProperty("out_columns")]
    public int Columns { get; set; }

    /// <summary>
    /// The spacing (in pixels) between each tile horizontally.
    /// </summary>
    [GameMakerProperty("out_tilehborder")]
    public int TileBorderHorizontal { get; set; }

    /// <summary>
    /// The spacing (in pixels) between each tile vertically.
    /// </summary>
    [GameMakerProperty("out_tilevborder")]
    public int TileBorderVertical { get; set; }

    /// <summary>
    /// The sprite connected to the tileset.
    /// </summary>
    [GameMakerProperty("spriteId")]
    public ResourceReference<GMSprite>? Sprite { get; set; }

    /// <summary>
    /// Whether to not export the sprite.
    /// </summary>
    [GameMakerProperty("spriteNoExport")]
    public bool DontExportSprite { get; set; }

    /// <summary>
    /// The texture group of the tileset texture.
    /// </summary>
    [GameMakerProperty("textureGroupId")]
    public ResourceReference<GMTextureGroup> TextureGroup { get; set; }

    /// <summary>
    /// The tile animation frames of the tileset.
    /// </summary>
    [GameMakerProperty("tileAnimationFrames")]
    public List<GMTileAnimation> TileAnimationFrames { get; set; } = new();

    /// <summary>
    /// The animation speed of the tileset.
    /// </summary>
    [GameMakerProperty("tileAnimationSpeed")]
    public float AnimationSpeed { get; set; }

    /// <summary>
    /// The height of each tile.
    /// </summary>
    [GameMakerProperty("tileHeight")]
    public int TileHeight { get; set; }

    /// <summary>
    /// The width of each tile.
    /// </summary>
    [GameMakerProperty("tileWidth")]
    public int TileWidth { get; set; }

    /// <summary>
    /// The amount of tiles in the tileset.
    /// </summary>
    [GameMakerProperty("tile_count")]
    public int TileCount { get; set; }

    /// <summary>
    /// The horizontal seperation of the tileset.
    /// </summary>
    [GameMakerProperty("tilehsep")]
    public int TileSeperationHorizontal { get; set; }

    /// <summary>
    /// The vertical seperation of the tileset.
    /// </summary>
    [GameMakerProperty("tilevsep")]
    public int TileSeperationVertical { get; set; }

    /// <summary>
    /// The X offset of the tileset.
    /// </summary>
    [GameMakerProperty("tilexoff")]
    public int TileOffsetX { get; set; }

    /// <summary>
    /// The Y offset of the tileset
    /// </summary>
    [GameMakerProperty("tileyoff")]
    public int TileOffsetY { get; set; }
    
    /// <summary>
    /// Auto tilesets.
    /// </summary>
    [YYVersion(0)]
    public class GMAutoTileSet : ResourceBase
    {
        /// <summary>
        /// Whether the auto tileset has closed edges.
        /// </summary>
        [GameMakerProperty("closed_edge")]
        public bool HasClosedEdge { get; set; }

        /// <summary>
        /// The tiles in the auto tileset.
        /// </summary>
        [GameMakerProperty("tiles")]
        public List<uint> Tiles { get; set; } = new();
    }
    
    /// <summary>
    /// An animation in a tileset.
    /// </summary>
    [YYVersion(0)]
    public class GMTileAnimation : ResourceBase
    {
        /// <summary>
        /// The frames in a tile animation.
        /// </summary>
        [GameMakerProperty("frames")]
        public List<uint> Frames { get; set; } = new();
    }
}