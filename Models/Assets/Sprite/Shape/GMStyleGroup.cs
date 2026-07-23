namespace YYModels.Models;

[YYVersion(0)]
public class GMStyleGroup : ResourceBase
{
    /// <summary>
    /// Style information about the fill sections.
    /// </summary>
    [GameMakerProperty("fillStyles")]
    public List<FillStyleData> FillStyles { get; set; }

    /// <summary>
    /// Style information about the shape outlines, Unused?
    /// </summary>
    [GameMakerProperty("lineStyleData")]
    public List<object> LineStyleData { get; set; }

    /// <summary>
    /// The shapes in the style group.
    /// </summary>
    [GameMakerProperty("shapes")]
    public List<GMSubShape> Shapes { get; set; }
}