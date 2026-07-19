namespace YYModels.Models;

/// <remarks>Version 0</remarks>
[GMResource("animcurves")]
public class GMAnimCurve : ResourceBase
{
    /// <summary>
    /// The channels in the animation curve.
    /// </summary>
    [GameMakerProperty("channels")]
    public List<GMAnimCurveChannel> Channels { get; set; }

    /// <summary>
    /// The type of the curve, see <see cref="CurveType"/>.
    /// </summary>
    [GameMakerProperty("function")]
    public CurveType Type { get; set; }
    
    /// <summary>
    /// The type of the animation curve.
    /// </summary>
    public enum CurveType
    {
        /// <summary>
        /// A linear, sharp curve.
        /// </summary>
        Linear,
        
        /// <summary>
        /// A smooth curve.
        /// </summary>
        Smooth,
        
        /// <summary>
        /// A bezier curve.
        /// </summary>
        Bezier,
    }
}
