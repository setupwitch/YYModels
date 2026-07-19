namespace YYModels.Models;

/// <remarks>Version 0</remarks>
[GMResource("objects")]
public class GMObject : ResourceBase
{
    /// <summary>
    /// The list of events in the object.
    /// </summary>
    [GameMakerProperty("eventList")]
    public List<GMEvent> Events { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("managed")]
    public bool IsManaged { get; set; }

    /// <summary>
    /// The <see cref="Properties"/> of the parent object that have been overridden.
    /// </summary>
    [GameMakerProperty("overriddenProperties")]
    public List<GMOverriddenProperty> OverriddenProperties { get; set; }

    /// <summary>
    /// The parent of the object.
    /// </summary>
    [GameMakerProperty("parentObjectId")]
    public ResourceReference<GMObject>? ParentObjectId { get; set; }

    /// <summary>
    /// Whether the object is persistent.
    /// </summary>
    [GameMakerProperty("persistent")]
    public bool IsPersistent { get; set; }

    /// <summary>
    /// Whether to enable angular damping.
    /// </summary>
    [GameMakerProperty("physicsAngularDamping")]
    public double AngularDamping { get; set; }

    /// <summary>
    /// The density of the object.
    /// </summary>
    [GameMakerProperty("physicsDensity")]
    public double Density { get; set; }

    /// <summary>
    /// The friction of the object.
    /// </summary>
    [GameMakerProperty("physicsFriction")]
    public double Friction { get; set; }

    /// <summary>
    /// The physics group that the object is in.
    /// </summary>
    [GameMakerProperty("physicsGroup")]
    public int PhysicsGroup { get; set; }

    /// <summary>
    /// Whether the object is kinematic.
    /// </summary>
    [GameMakerProperty("physicsKinematic")]
    public bool IsKinematic { get; set; }

    /// <summary>
    /// The amount of linear damping of the object.
    /// </summary>
    [GameMakerProperty("physicsLinearDamping")]
    public double LinearDamping { get; set; }

    /// <summary>
    /// Whether the object has physics enabled.
    /// </summary>
    [GameMakerProperty("physicsObject")]
    public bool IsPhysicsObject { get; set; }

    /// <summary>
    /// The restitution of the object.
    /// </summary>
    [GameMakerProperty("physicsRestitution")]
    public double Restitution { get; set; }

    /// <summary>
    /// Whether the object is a sensor.
    /// </summary>
    [GameMakerProperty("physicsSensor")]
    public bool IsSensor { get; set; }

    /// <summary>
    /// The shape of the object.
    /// </summary>
    [GameMakerProperty("physicsShape")]
    public int PhysicsShape { get; set; }

    /// <summary>
    /// The objects collision shape for physics.
    /// </summary>
    [GameMakerProperty("physicsShapePoints")]
    public Point[] ShapePoints { get; set; }

    /// <summary>
    /// Whether to start with physics awake.
    /// </summary>
    [GameMakerProperty("physicsStartAwake")]
    public bool StartAwake { get; set; }

    /// <summary>
    /// The Variable Definitions of the object.
    /// </summary>
    [GameMakerProperty("properties")]
    public List<GMObjectProperty> Properties { get; set; }

    /// <summary>
    /// Whether the instance is solid.
    /// </summary>
    [GameMakerProperty("solid")]
    public bool IsSolid { get; set; }

    /// <summary>
    /// The sprite of the object.
    /// </summary>
    [GameMakerProperty("spriteId")]
    public ResourceReference<GMSprite>? SpriteId { get; set; }

    /// <summary>
    /// The sprite to use as a collision mask for the object.
    /// </summary>
    [GameMakerProperty("spriteMaskId")]
    public ResourceReference<GMSprite>? SpriteMaskId { get; set; }

    /// <summary>
    /// Whether the object is visible.
    /// </summary>
    [GameMakerProperty("visible")]
    public bool IsVisible { get; set; }
}