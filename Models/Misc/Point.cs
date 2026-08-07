namespace YYModels.Models
{
    public class Point
    {
        /// <summary>
        /// The X position for the point
        /// </summary>
        [GameMakerProperty("x")]
        public float X { get; set; }

        /// <summary>
        /// The Y position for the point
        /// </summary>
        [GameMakerProperty("y")]
        public float Y { get; set; }
    }
}
