namespace YYModels.Models;

public class FontRange
{
    /// <summary>
    /// The starting ASCII character of the range.
    /// </summary>
    [GameMakerProperty("lower")]
    public int Start { get; set; }

    /// <summary>
    /// The ending ASCII character of the range.
    /// </summary>
    [GameMakerProperty("upper")]
    public int End { get; set; }
}