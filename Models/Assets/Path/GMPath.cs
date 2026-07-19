namespace YYModels.Models;

/// <remarks>Version 0</remarks>
[GMResource("paths")]
public class GMPath : ResourceBase
{
    /// <summary>
    /// Whether the path is a closed loop.
    /// </summary>
    [GameMakerProperty("closed")]
    public bool IsClosed { get; set; }

    /// <summary>
    /// Whether the path is straight or smooth.
    /// </summary>
    [GameMakerProperty("kind")]
    public PathType Type { get; set; }

    /// <summary>
    /// An array of points for the path to follow.
    /// </summary>
    [GameMakerProperty("points")]
    public List<PathPoint> Points { get; set; }

    /// <summary>
    /// The precision of the path, only used when <see cref="PathType"/> is Smooth Curve.
    /// </summary>
    [GameMakerProperty("precision")]
    public int Precision { get; set; }
    
    public class PathPoint
    {
        /// <summary>
        /// A percentage of how fast an instance will go through the path.
        /// </summary>
        [GameMakerProperty("speed")]
        public float Speed { get; set; }

        /// <inheritdoc cref="Point.X"/>
        [GameMakerProperty("x")]
        public float X { get; set; }

        /// <inheritdoc cref="Point.Y"/>
        [GameMakerProperty("y")]
        public float Y { get; set; }
    }
    
    /// <summary>
    /// The kind of path it is.
    /// </summary>
    public enum PathType
    {
        /// <summary>
        /// No smoothing.
        /// </summary>
        Sharp = 0,
        
        /// <summary>
        /// Yes smoothing.
        /// </summary>
        Smooth = 1,
    }
}