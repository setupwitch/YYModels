namespace YYModels.Models;

/// <remarks>Version 0</remarks>
[GMResource("timelines")]
public class GMTimeline : ResourceBase
{
    /// <summary>
    /// A list of moments for the timeline.
    /// </summary>
    [GameMakerProperty("momentList")]
    public List<GMMoment> Moments { get; set; }
}