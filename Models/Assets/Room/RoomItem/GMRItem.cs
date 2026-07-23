namespace YYModels.Models;

/// <summary>
/// The base room item class.
/// </summary>
[YYVersion(0)]
[GameMakerPolymorphic]
[GameMakerDerivedType(typeof(GMRInstance), nameof(GMRInstance))]
[GameMakerDerivedType(typeof(GMRGraphic), nameof(GMRGraphic))]
[GameMakerDerivedType(typeof(GMRSpriteGraphic), nameof(GMRSpriteGraphic))]
[GameMakerDerivedType(typeof(GMRSequenceGraphic), nameof(GMRSequenceGraphic))]
[GameMakerDerivedType(typeof(GMRTextItem), nameof(GMRTextItem))]
[GameMakerDerivedType(typeof(GMRParticleSystem), nameof(GMRParticleSystem))]
public class GMRItem : ResourceBase
{
    /// <summary>
    /// The flex properties for the item in UI layers.
    /// </summary>
    [GameMakerProperty("flexProperties")]
    public FlexProperties? FlexProperties { get; set; }

    /// <summary>
    /// Whether the item is frozen.
    /// </summary>
    [GameMakerProperty("frozen")]
    public bool IsFrozen { get; set; }

    /// <summary>
    /// Unknown, Whether to ignore the item?
    /// </summary>
    [GameMakerProperty("ignore")]
    public bool IsIgnored { get; set; }

    /// <summary>
    /// Whether to inherit the parent items settings.
    /// </summary>
    [GameMakerProperty("inheritItemSettings")]
    public bool InheritSettings { get; set; }

    /// <summary>
    /// The parent item.
    /// </summary>
    [GameMakerProperty("inheritedItemId")]
    public ResourceReference<GMRItem>? InheritedItem { get; set; }

    /// <summary>
    /// The X position of the item.
    /// </summary>
    [GameMakerProperty("x")]
    public float X { get; set; }

    /// <summary>
    /// The Y position of the item.
    /// </summary>
    [GameMakerProperty("y")]
    public float Y { get; set; }
}
