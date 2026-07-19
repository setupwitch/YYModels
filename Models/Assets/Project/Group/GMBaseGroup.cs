namespace YYModels.Models;

/// <remarks>Version 0</remarks>
public class GMBaseGroup : ResourceBase
{
    /// <summary>
    /// The targets to export the group to.
    /// </summary>
    [GameMakerProperty("targets")]
    public TargetPlatforms ExportTargets { get; set; }
}