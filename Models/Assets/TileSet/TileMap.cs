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
    /// RLE compressed tile data (used when <see cref="TileDataFormat"/> is 1).
    /// </summary>
    [GameMakerProperty("TileCompressedData")]
    [GameMakerIgnoreWhenWritingNull]
    public List<int>? TileCompressedData { get; set; } = null;
    
    /// <summary>
    /// raw uncompressed 1D tile data (used when <see cref="TileDataFormat"/> is 0).
    /// </summary>
    [GameMakerProperty("TileSerialiseData")]
    [GameMakerIgnoreWhenWritingNull]
    public List<uint>? TileSerialiseData { get; set; } = null;

    /// <summary>
    /// The format of the tile data.
    /// </summary>
    /// <list type="bullet">
    ///   <item><description><c>0</c> Uncompressed (<see cref="TileSerialiseData"/>)</description></item>
    ///   <item><description><c>1</c> RLE Compressed (<see cref="TileCompressedData"/>)</description></item>
    /// </list>
    [GameMakerProperty("TileDataFormat")]
    public int TileDataFormat { get; set; }
}