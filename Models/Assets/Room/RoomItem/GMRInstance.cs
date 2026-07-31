namespace YYModels.Models;

/// <summary>
/// An instance in a <see cref="GMRInstanceLayer"/>.
/// </summary>
[YYVersion(4)]
public class GMRInstance : GMRItem
{
    /// <summary>
    /// The color of the instance.
    /// </summary>
    [GameMakerProperty("colour")]
    public uint Color { get; set; }

    /// <summary>
    /// Whether the instance has creation code.
    /// </summary>
    [GameMakerProperty("hasCreationCode")]
    public bool HasCreationCode { get; set; }

    /// <summary>
    /// The image index of the instance.
    /// </summary>
    [GameMakerProperty("imageIndex")]
    public int ImageIndex { get; set; }

    /// <summary>
    /// the image speed of the index.
    /// </summary>
    [GameMakerProperty("imageSpeed")]
    public float ImageSpeed { get; set; }

    /// <summary>
    /// Whether to inherit the code of the parent instance.
    /// </summary>
    [GameMakerProperty("inheritCode")]
    public bool InheritCode { get; set; }

    /// <summary>
    /// Whether the instance is in "drag and drop" mode.
    /// </summary>
    [GameMakerProperty("isDnd")]
    public bool IsDragAndDrop { get; set; }

    /// <summary>
    /// A reference to the game object.
    /// </summary>
    [GameMakerProperty("objectId")]
    public ResourceReference<GMObject>? ObjectId { get; set; }

    /// <summary>
    /// A list of <see cref="GMOverriddenProperty"/> objects for the instance.
    /// </summary>
    [GameMakerProperty("properties")]
    public List<GMOverriddenProperty> Properties { get; set; } = new();

    /// <summary>
    /// The rotation of the instance.
    /// </summary>
    [GameMakerProperty("rotation")]
    public float Rotation { get; set; }

    /// <summary>
    /// The X scale of the instance.
    /// </summary>
    [GameMakerProperty("scaleX")]
    public float ScaleX { get; set; }

    /// <summary>
    /// The Y scale of the instance.
    /// </summary>
    [GameMakerProperty("scaleY")]
    public float ScaleY { get; set; }
    
    
    /// <remarks>Possibly Unused</remarks>
    [YYVersion(1)]
    public class InstanceFlexProps : ResourceBase
    {
        
    }
}