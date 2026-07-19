namespace YYModels.Models;

public class FlexValue
{
    /// <summary>
    /// The unit of the flex value in <see cref="Unit"/>.
    /// </summary>
    [GameMakerProperty("unit")]
    public Unit PlacementUnit { get; set; }

    /// <summary>
    /// The value of the flex value.
    /// </summary>
    [GameMakerProperty("value")]
    public float Value { get; set; }
    
    public enum Unit
    {
        Undefined = 0,
        Point = 1,
        Percent = 2,
        Auto = 3,
    }
}