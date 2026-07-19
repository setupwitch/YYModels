namespace YYModels.Models;

/// <remarks>Version 0</remarks>
public class GMRUIContainer : ResourceBase, IGMRUI
{
    /// <summary>
    /// The children of the container.
    /// </summary>
    [GameMakerProperty("children")]
    public List<IGMRUI> Children { get; set; }

    /// <summary>
    /// The color of the node.
    /// </summary>
    [GameMakerProperty("nodeColour")]
    public uint NodeColor { get; set; }
}