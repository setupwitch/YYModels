namespace YYModels.Models;

public class FontGlyph
{
    /// <summary>
    /// The ASCII character of the glyph.
    /// </summary>
    [GameMakerProperty("character")]
    public int Character { get; set; }

    /// <summary>
    /// The height of the glyph
    /// </summary>
    [GameMakerProperty("h")]
    public int Height { get; set; }

    /// <summary>
    /// The horizontal offset of the glyph in pixels.
    /// </summary>
    [GameMakerProperty("offset")]
    public int Offset { get; set; }

    /// <summary>
    /// How much to shift the glyph to the right in pixels.
    /// </summary>
    [GameMakerProperty("shift")]
    public int Shift { get; set; }

    /// <summary>
    /// The width of the glyph
    /// </summary>
    [GameMakerProperty("w")]
    public int Width { get; set; }

    /// <summary>
    /// The X position for the glyph
    /// </summary>
    [GameMakerProperty("x")]
    public int X { get; set; }

    /// <summary>
    /// The Y position for the glyph
    /// </summary>
    [GameMakerProperty("y")]
    public int Y { get; set; }
}