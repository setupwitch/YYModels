namespace YYModels.Models;

[YYVersion(0)]
public class GMBaseGroup : ResourceBase
{
    /// <summary>
    /// The targets to export the group to.
    /// </summary>
    [GameMakerProperty("targets")]
    public TargetPlatforms ExportTargets { get; set; }
}