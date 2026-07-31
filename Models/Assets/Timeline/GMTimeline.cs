namespace YYModels.Models;

[YYVersion(0)]
[GMResource("timelines")]
public class GMTimeline : ResourceBase
{
    /// <summary>
    /// A list of moments for the timeline.
    /// </summary>
    [GameMakerProperty("momentList")]
    public List<GMMoment> Moments { get; set; } = new();
}