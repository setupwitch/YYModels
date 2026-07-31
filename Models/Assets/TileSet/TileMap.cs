namespace YYModels.Models;

/// <summary>
/// A Tilemap.
/// </summary>
public class TileMap
{
    /// <summary>
    /// The height of the tilemap.
    /// </summary>
    [GameMakerProperty("SerialiseHeight")]
    public int SerializeHeight { get; set; }

    /// <summary>
    /// The width of the tilemap.
    /// </summary>
    [GameMakerProperty("SerialiseWidth")]
    public int SerializeWidth { get; set; }

    /// <summary>
    /// The compressed tile data.
    /// </summary>
    [GameMakerProperty("TileCompressedData")]
    public List<int> TileCompressedData { get; set; } = new();

    /// <summary>
    /// The format of the tile data, Unknown values.
    /// </summary>
    [GameMakerProperty("TileDataFormat")]
    public int TileDataFormat { get; set; }
}