namespace YYModels.Models;

[YYVersion(0)]
public class GMMoment : ResourceBase
{
    /// <summary>
    /// The event of the moment
    /// </summary>
    [GameMakerProperty("evnt")]
    public GMEvent Event { get; set; }

    /// <summary>
    /// The moment number.
    /// </summary>
    [GameMakerProperty("moment")]
    public int Moment { get; set; }
}