namespace YYModels.Models;

public class KerningPair
{
    /// <summary>
    /// The pixels to shift to the right of the characters.
    /// </summary>
    [GameMakerProperty("amount")]
    public int ShiftAmount { get; set; }

    /// <summary>
    /// The first ASCII character to start from.
    /// </summary>
    [GameMakerProperty("first")]
    public int StartCharacter { get; set; }

    /// <summary>
    /// The last ASCII character to end on.
    /// </summary>
    [GameMakerProperty("second")]
    public int EndCharacter { get; set; }
}