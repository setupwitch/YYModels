namespace YYModels.Models;

/// <summary>
/// A particle system emitter in a <see cref="GMRAssetLayer"/>.
/// </summary>
/// <remarks>Version 1</remarks>
public class GMRParticleSystem : GMRItem
{
    /// <summary>
    /// The color of the sequence.
    /// </summary>
    [GameMakerProperty("colour")]
    public uint Color { get; set; }

    /// <summary>
    /// The <see cref="GMParticleSystem"/> in the item.
    /// </summary>
    [GameMakerProperty("particleSystemId")]
    public ResourceReference<GMParticleSystem>? ParticleSystemId { get; set; }

    /// <summary>
    /// The rotation of the item.
    /// </summary>
    [GameMakerProperty("rotation")]
    public float Rotation { get; set; }

    /// <summary>
    /// The X scale of the item.
    /// </summary>
    [GameMakerProperty("scaleX")]
    public float ScaleX { get; set; }

    /// <summary>
    /// The Y scale of the item.
    /// </summary>
    [GameMakerProperty("scaleY")]
    public float ScaleY { get; set; }
}