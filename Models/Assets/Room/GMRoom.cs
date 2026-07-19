namespace YYModels.Models;

/// <remarks>Version 1</remarks>
[GMResource("rooms")]
public partial class GMRoom : ResourceBase
{
    /// <summary>
    /// The relative path to the creation code file.
    /// </summary>
    [GameMakerProperty("creationCodeFile")]
    public string CreationCodePath { get; set; }

    /// <summary>
    /// Unknown, possibly meant for inheritance of roomCC?
    /// </summary>
    [GameMakerProperty("inheritCode")]
    public bool InheritCode { get; set; }

    /// <summary>
    /// Unknown, possibly meant for inheritance of the creation order?
    /// </summary>
    [GameMakerProperty("inheritCreationOrder")]
    public bool InheritCreationOrder { get; set; }

    /// <summary>
    /// Whether to inherit room layers.
    /// </summary>
    [GameMakerProperty("inheritLayers")]
    public bool InheritLayers { get; set; }

    /// <summary>
    /// The creation order of the instances.
    /// </summary>
    [GameMakerProperty("instanceCreationOrder")]
    public List<ResourceReference<GMRItem>> InstanceCreationOrder { get; set; }

    /// <summary>
    /// Whether the asset is in "drag and drop" mode.
    /// </summary>
    [GameMakerProperty("isDnd")]
    public bool IsDragAndDrop { get; set; }

    /// <summary>
    /// The layers in the room
    /// </summary>
    [GameMakerProperty("layers")]
    public List<GMRLayer> Layers { get; set; }

    /// <summary>
    /// The parent room.
    /// </summary>
    [GameMakerProperty("parentRoom")]
    public ResourceReference<GMRoom> ParentRoom { get; set; }

    /// <summary>
    /// the physics settings in the room.
    /// </summary>
    [GameMakerProperty("physicsSettings")]
    public GMRoomPhysicsSettings PhysicsSettings { get; set; }

    /// <summary>
    /// The general settings in the room.
    /// </summary>
    [GameMakerProperty("roomSettings")]
    public GMRoomSettings Settings { get; set; }

    /// <summary>
    /// The sequence applied to the room.
    /// </summary>
    [GameMakerProperty("sequenceId")]
    public ResourceReference<GMSequence> SequenceId { get; set; }

    /// <summary>
    /// The view settings in the room.
    /// </summary>
    [GameMakerProperty("viewSettings")]
    public GMRoomViewSettings ViewSettings { get; set; }

    /// <summary>
    /// The views that the room has
    /// </summary>
    [GameMakerProperty("views")]
    public List<RoomView> Views { get; set; }

    /// <summary>
    /// The volume of the room ...
    /// </summary>
    [GameMakerProperty("volume")]
    public float Volume { get; set; }
    
    /// <summary>
    /// General settings for a room.
    /// </summary>
    public class GMRoomSettings
    {
        /// <summary>
        /// The height of the room.
        /// </summary>
        [GameMakerProperty("Height")]
        public int Height { get; set; }

        /// <summary>
        /// The width of the room.
        /// </summary>
        [GameMakerProperty("Width")]
        public int Width { get; set; }

        /// <summary>
        /// Whether to inherit the settings from the parent room.
        /// </summary>
        [GameMakerProperty("inheritRoomSettings")]
        public bool InheritSettings { get; set; }

        /// <summary>
        /// Whether the room is persistent.
        /// </summary>
        [GameMakerProperty("persistent")]
        public bool IsPersistent { get; set; }

    }

    /// <summary>
    /// The view settings for the room.
    /// </summary>
    public class GMRoomViewSettings
    {
        /// <summary>
        /// Clear the display buffer after every frame.
        /// </summary>
        [GameMakerProperty("clearDisplayBuffer")]
        public bool ClearDisplayBuffer { get; set; }

        /// <summary>
        /// Clear the viewport background after every frame.
        /// </summary>
        [GameMakerProperty("clearViewBackground")]
        public bool ClearViewBackground { get; set; }

        /// <summary>
        /// Whether to enable views in the room.
        /// </summary>
        [GameMakerProperty("enableViews")]
        public bool EnableViews { get; set; }

        /// <summary>
        /// Whether to inherit the view settings from the parent room.
        /// </summary>
        [GameMakerProperty("inheritViewSettings")]
        public bool InheritSettings { get; set; }

    }
    
    /// <summary>
    /// The physics settings for the room.
    /// </summary>
    public class GMRoomPhysicsSettings
    {
        /// <summary>
        /// Whether physics is enabled or not.
        /// </summary>
        [GameMakerProperty("PhysicsWorld")]
        public bool PhysicsWorld { get; set; }

        /// <summary>
        /// The X gravity of the physics.
        /// </summary>
        [GameMakerProperty("PhysicsWorldGravityX")]
        public float PhysicsWorldGravityX { get; set; }

        /// <summary>
        /// The Y gravity of the physics.
        /// </summary>
        [GameMakerProperty("PhysicsWorldGravityY")]
        public float PhysicsWorldGravityY { get; set; }

        /// <summary>
        /// Pixels to meters.
        /// </summary>
        [GameMakerProperty("PhysicsWorldPixToMetres")]
        public float PhysicsWorldPixToMetres { get; set; }

        /// <summary>
        /// Whether to inherit the physics settings from the parent room.
        /// </summary>
        [GameMakerProperty("inheritPhysicsSettings")]
        public bool InheritSettings { get; set; }

    }
}