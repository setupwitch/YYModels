namespace YYModels.Models;

/// <remarks>Version 0</remarks>
[GMResource("particles")]
public class GMParticleSystem : ResourceBase
{
    /// <summary>
    /// The height of the backdrop.
    /// </summary>
    [GameMakerProperty("backdropHeight")]
    public int BackdropHeight { get; set; }

    /// <summary>
    /// The opacity of the backdrop image.
    /// </summary>
    [GameMakerProperty("backdropImageOpacity")]
    public float BackdropImageOpacity { get; set; }

    /// <summary>
    /// The path to the backdrop image.
    /// </summary>
    [GameMakerProperty("backdropImagePath")]
    public string BackdropImagePath { get; set; }

    /// <summary>
    /// The width of the backdrop.
    /// </summary>
    [GameMakerProperty("backdropWidth")]
    public int BackdropWidth { get; set; }

    /// <summary>
    /// The X offset of the backdrop.
    /// </summary>
    [GameMakerProperty("backdropXOffset")]
    public float BackdropXOffset { get; set; }

    /// <summary>
    /// The Y offset of the backdrop.
    /// </summary>
    [GameMakerProperty("backdropYOffset")]
    public float BackdropYOffset { get; set; }

    /// <summary>
    /// The draw order of the particle system, see <see cref="ParticleSystemDrawOrder"/>.
    /// </summary>
    [GameMakerProperty("drawOrder")]
    public ParticleSystemDrawOrder DrawOrder { get; set; }

    /// <summary>
    /// The Particle System Emitters in the Particle System.
    /// </summary>
    [GameMakerProperty("emitters")]
    public List<GMPSEmitter> Emitters { get; set; }

    /// <summary>
    /// Whether to show the backdrop.
    /// </summary>
    [GameMakerProperty("showBackdrop")]
    public bool ShowBackdrop { get; set; }

    /// <summary>
    /// Whether to show the backdrop image.
    /// </summary>
    [GameMakerProperty("showBackdropImage")]
    public bool ShowBackdropImage { get; set; }

    /// <summary>
    /// The X origin of the particle system.
    /// </summary>
    [GameMakerProperty("xorigin")]
    public int XOrigin { get; set; }

    /// <summary>
    /// The Y origin of the particle system.
    /// </summary>
    [GameMakerProperty("yorigin")]
    public int YOrigin { get; set; }
    
    /// <summary>
    /// The draw order of the backdrop.
    /// </summary>
    public enum ParticleSystemDrawOrder
    {
        /// <remarks>New on top.</remarks>
        Default,
        /// <remarks>Old on top.</remarks>
        Reversed,
    }
}

