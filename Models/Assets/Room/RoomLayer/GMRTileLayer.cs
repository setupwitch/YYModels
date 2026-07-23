namespace YYModels.Models;

/// <summary>
/// A tile layer in a room.
/// </summary>
[YYVersion(0)]
public class GMRTileLayer : GMRLayer
{
    /// <summary>
    /// The tilemap of the layer.
    /// </summary>
    [GameMakerProperty("tiles")]
    public TileMap TileMap { get; set; }

    /// <summary>
    /// A reference to the tileset.
    /// </summary>
    [GameMakerProperty("tilesetId")]
    public ResourceReference<GMTileSet>? TileSet { get; set; }

    /// <summary>
    /// The X offset of the tile layer.
    /// </summary>
    [GameMakerProperty("x")]
    public int X { get; set; }

    /// <summary>
    /// The Y offset of the tile layer.
    /// </summary>
    [GameMakerProperty("y")]
    public int Y { get; set; }
}