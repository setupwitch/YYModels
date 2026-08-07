namespace YYModels.Models;

public partial class GMRoom
{
    /// <summary>
    /// A view in a room.
    /// </summary>
    public class RoomView
    {
        /// <summary>
        /// The horizontal border of the following object.
        /// </summary>
        [GameMakerProperty("hborder")]
        public int HorizontalBorder { get; set; }

        /// <summary>
        /// The height of the viewport.
        /// </summary>
        [GameMakerProperty("hport")]
        public int PortHeight { get; set; }

        /// <summary>
        /// The horizontal speed of the following object.
        /// </summary>
        [GameMakerProperty("hspeed")]
        public int HorizontalSpeed { get; set; }

        /// <summary>
        /// The height of the camera.
        /// </summary>
        [GameMakerProperty("hview")]
        public int CameraHeight { get; set; }

        /// <summary>
        /// Unknown, possibly whether its inherited?
        /// </summary>
        [GameMakerProperty("inherit")]
        public bool InheritView { get; set; }

        /// <summary>
        /// A reference to the following object.
        /// </summary>
        [GameMakerProperty("objectId")]
        public ResourceReference<GMObject>? ObjectId { get; set; }

        /// <summary>
        /// The vertical border of the following object.
        /// </summary>
        [GameMakerProperty("vborder")]
        public int VerticalBorder { get; set; }

        /// <summary>
        /// Whether the view is visible
        /// </summary>
        [GameMakerProperty("visible")]
        public bool IsVisible { get; set; }

        /// <summary>
        /// The vertical speed of the following object.
        /// </summary>
        [GameMakerProperty("vspeed")]
        public int VerticalSpeed { get; set; }

        /// <summary>
        /// The width of the viewport.
        /// </summary>
        [GameMakerProperty("wport")]
        public int PortWidth { get; set; }

        /// <summary>
        /// The width of the camera.
        /// </summary>
        [GameMakerProperty("wview")]
        public int CameraWidth { get; set; }

        /// <summary>
        /// The X position of the viewport.
        /// </summary>
        [GameMakerProperty("xport")]
        public int PortX { get; set; }

        /// <summary>
        /// The X position of the camera.
        /// </summary>
        [GameMakerProperty("xview")]
        public int CameraX { get; set; }

        /// <summary>
        /// The Y position of the viewport.
        /// </summary>
        [GameMakerProperty("yport")]
        public int PortY { get; set; }

        /// <summary>
        /// The Y position of the camera.
        /// </summary>
        [GameMakerProperty("yview")]
        public int CameraY { get; set; }
    }
}