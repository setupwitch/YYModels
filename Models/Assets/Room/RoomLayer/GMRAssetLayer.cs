namespace YYModels.Models;

/// <summary>
/// An asset layer in a room
/// </summary>
[YYVersion(0)]
public class GMRAssetLayer : GMRLayer
{
    /// <summary>
    /// The assets inside of the layer.
    /// </summary>
    [GameMakerProperty("assets")]
    public List<GMRItem> Assets { get; set; }
}