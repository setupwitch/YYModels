namespace YYModels.Models;

[YYVersion(1)]
[GMResource("sequences")]
public partial class GMSequence : ResourceBase
{
    /// <summary>
    /// Unknown, always true?
    /// </summary>
    [GameMakerProperty("autoRecord")]
    public bool AutoRecord { get; set; }

    /// <summary>
    /// The height of the backdrop.
    /// </summary>
    [GameMakerProperty("backdropHeight")]
    public int BackdropHeight { get; set; }

    /// <summary>
    /// The opacity of the backdrop
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
    /// The Y offset of the backdrop
    /// </summary>
    [GameMakerProperty("backdropYOffset")]
    public float BackdropYOffset { get; set; }

    /// <summary>
    /// A reference to the stub script. TODO: find out what stub means in this context?
    /// </summary>
    [GameMakerProperty("eventStubScript")]
    public ResourceReference<GMScript>? EventStubScript { get; set; }

    /// <summary>
    /// Event number to function.
    /// </summary>
    [GameMakerProperty("eventToFunction")]
    public Dictionary<int, string> EventToFunction { get; set; } = new();

    /// <summary>
    /// The message events in the sequence.
    /// </summary>
    [GameMakerProperty("events")]
    public KeyframeStore<MessageEventKeyframe> Events { get; set; } = new();

    /// <summary>
    /// The length (in seconds) of the sequence.
    /// </summary>
    [GameMakerProperty("length")]
    public float Length { get; set; }

    /// <summary>
    /// Whether to lock the origin?
    /// </summary>
    [GameMakerProperty("lockOrigin")]
    public bool LockOrigin { get; set; }

    /// <summary>
    /// The moments in the sequence.
    /// </summary>
    [GameMakerProperty("moments")]
    public KeyframeStore<MomentsEventKeyframe> Moments { get; set; } = new();

    /// <summary>
    /// The <see cref="Playback"/> type of the sequence.
    /// </summary>
    [GameMakerProperty("playback")]
    public Playback PlaybackType { get; set; }

    /// <summary>
    /// The playback speed of the sequence.
    /// </summary>
    [GameMakerProperty("playbackSpeed")]
    public float PlaybackSpeed { get; set; }

    /// <summary>
    /// The playback speed type of the sequence, see <see cref="TimeUnits"/>.
    /// </summary>
    [GameMakerProperty("playbackSpeedType")]
    public TimeUnits PlaybackSpeedType { get; set; }

    /// <summary>
    /// The height of the sequence.
    /// </summary>
    [GameMakerProperty("seqHeight")]
    [GameMakerIgnoreWhenWritingNull]
    public float? Height { get; set; }

    /// <summary>
    /// The width of the sequence.
    /// </summary>
    [GameMakerProperty("seqWidth")]
    [GameMakerIgnoreWhenWritingNull]
    public float? Width { get; set; }

    /// <summary>
    /// Whether to show the backdrop of the sequence.
    /// </summary>
    [GameMakerProperty("showBackdrop")]
    public bool ShowBackdrop { get; set; }

    /// <summary>
    /// Whether to show the backdrop image of the sequence
    /// </summary>
    [GameMakerProperty("showBackdropImage")]
    public bool ShowBackdropImage { get; set; }

    /// <summary>
    /// A reference to a sprite, used for embedded sequences in sprites.
    /// </summary>
    [GameMakerProperty("spriteId")]
    [GameMakerIgnoreWhenWritingNull]
    public ResourceReference<GMSprite>? Sprite { get; set; }

    /// <summary>
    /// The <see cref="TimeUnits"/> of the sequence.
    /// </summary>
    [GameMakerProperty("timeUnits")]
    public TimeUnits TimeUnits { get; set; }

    /// <summary>
    /// The tracks in the sequence.
    /// </summary>
    [GameMakerProperty("tracks")]
    public List<GMBaseTrack> Tracks { get; set; } = new();

    /// <summary>
    /// The visible range of the sequence? unknown.
    /// </summary>
    [GameMakerProperty("visibleRange")]
    public Point VisibleRange { get; set; }

    /// <summary>
    /// The volume of the sequence.
    /// </summary>
    [GameMakerProperty("volume")]
    public float Volume { get; set; }

    /// <summary>
    /// The X origin of the sequence.
    /// </summary>
    [GameMakerProperty("xorigin")]
    public int OriginX { get; set; }

    /// <summary>
    /// The Y origin of the sequence.
    /// </summary>
    [GameMakerProperty("yorigin")]
    public int OriginY { get; set; }
}