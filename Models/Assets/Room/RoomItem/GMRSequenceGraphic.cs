namespace YYModels.Models;

/// <summary>
/// A sequence graphic in a <see cref="GMRAssetLayer"/>.
/// </summary>
[YYVersion(1)]
public class GMRSequenceGraphic : GMRItem
{
    /// <summary>
    /// The animation speed of the sequence.
    /// </summary>
    [GameMakerProperty("animationSpeed")]
    public float ImageSpeed { get; set; }

    /// <summary>
    /// The color of the sequence.
    /// </summary>
    [GameMakerProperty("colour")]
    public uint Color { get; set; }

    /// <summary>
    /// The starting frame of the sequence.
    /// </summary>
    [GameMakerProperty("headPosition")]
    public float ImageIndex { get; set; } = 0f;

    /// <summary>
    /// The rotation of the sequence.
    /// </summary>
    [GameMakerProperty("rotation")]
    public float Rotation { get; set; }

    /// <summary>
    /// The X scale of the sequence.
    /// </summary>
    [GameMakerProperty("scaleX")]
    public float ScaleX { get; set; }

    /// <summary>
    /// The Y scale of the sequence.
    /// </summary>
    [GameMakerProperty("scaleY")]
    public float ScaleY { get; set; }

    /// <summary>
    /// A reference to the sequence.
    /// </summary>
    [GameMakerProperty("sequenceId")]
    public ResourceReference<GMSequence>? Sequence { get; set; }
}