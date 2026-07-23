namespace YYModels.Models;

[YYVersion(1)]
public class GMOverriddenProperty : ResourceBase
{
    /// <summary>
    /// The current object.
    /// </summary>
    [GameMakerProperty("objectId")]
    public ResourceReference<GMObject> ObjectId { get; set; }

    /// <summary>
    /// The object that the property originates from.
    /// </summary>
    [GameMakerProperty("propertyId")]
    public ResourceReference<GMObject> PropertyId { get; set; }

    /// <summary>
    /// The overridden value of the property.
    /// </summary>
    [GameMakerProperty("value")]
    public string Value { get; set; }
}