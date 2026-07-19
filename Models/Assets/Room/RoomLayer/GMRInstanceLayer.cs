namespace YYModels.Models;

/// <summary>
/// An instance layer in a room.
/// </summary>
/// <remarks>Version 0</remarks>
public class GMRInstanceLayer : GMRLayer
{
    /// <summary>
    /// The instances inside of the layer.
    /// </summary>
    [GameMakerProperty("instances")]
    public List<GMRInstance> Instances { get; set; }
}