namespace YYModels.Models;

/// <remarks>Version 1</remarks>
public class GMEvent : ResourceBase
{
    /// <summary>
    /// A reference to the colliding object if this is a collision event.
    /// </summary>
    [GameMakerProperty("collisionObjectId")]
    public ResourceReference<GMObject>? CollisionObjectId { get; set; }

    /// <summary>
    /// The event number.
    /// </summary>
    [GameMakerProperty("eventNum")]
    public int EventNumber { get; set; }

    /// <summary>
    /// The event type.
    /// </summary>
    [GameMakerProperty("eventType")]
    public EventTypeEnum EventType { get; set; }

    /// <summary>
    /// Whether the event uses GML visual.
    /// </summary>
    [GameMakerProperty("isDnD")]
    public bool IsDragAndDrop { get; set; }
}