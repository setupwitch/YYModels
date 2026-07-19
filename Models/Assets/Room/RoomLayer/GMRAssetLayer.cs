namespace YYModels.Models;

/// <summary>
/// An asset layer in a room
/// </summary>
/// <remarks>Version 0</remarks>
public class GMRAssetLayer : GMRLayer
{
    /// <summary>
    /// The assets inside of the layer.
    /// </summary>
    [GameMakerProperty("assets")]
    public List<GMRItem> Assets { get; set; }
}