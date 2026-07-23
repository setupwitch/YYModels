namespace YYModels.Models;

[YYVersion(0)]
public class GMPSEmitter : ResourceBase
{
    /// <summary>
    /// The name of the preset.
    /// </summary>
    [GameMakerProperty("GMPresetName")]
    public string? PresetName { get; set; }

    /// <summary>
    /// Whether to apply additive blend to the particle.
    /// </summary>
    [GameMakerProperty("additiveBlend")]
    public bool ApplyAdditiveBlend { get; set; }

    /// <summary>
    /// How much to increase the direction to give to the particle.
    /// </summary>
    [GameMakerProperty("directionIncrease")]
    public float DirectionIncrease { get; set; }

    /// <summary>
    /// The maximum direction to emit particles to.
    /// </summary>
    [GameMakerProperty("directionMax")]
    public float DirectionMax { get; set; }

    /// <summary>
    /// The minimum direction to emit particles to.
    /// </summary>
    [GameMakerProperty("directionMin")]
    public float DirectionMin { get; set; }

    /// <summary>
    /// The amount to wiggle the direction.
    /// </summary>
    [GameMakerProperty("directionWiggle")]
    public float DirectionWiggle { get; set; }

    /// <summary>
    /// The distribution of the particles, see <see cref="ParticleDistribution"/>.
    /// </summary>
    [GameMakerProperty("distribution")]
    public ParticleDistribution Distribution { get; set; }

    /// <summary>
    /// The color of the preview.
    /// </summary>
    [GameMakerProperty("editorColour")]
    public uint EditorColor { get; set; }

    /// <summary>
    /// Whether to preview the Emitter radius.
    /// </summary>
    [GameMakerProperty("editorDrawShape")]
    public bool DrawShape { get; set; }

    /// <summary>
    /// The amount of particles to emit.
    /// </summary>
    [GameMakerProperty("emitCount")]
    public int EmitCount { get; set; }

    /// <summary>
    /// The maximum delay to emit a particle.
    /// </summary>
    [GameMakerProperty("emitDelayMax")]
    public float DelayMax { get; set; }

    /// <summary>
    /// The minimum delay to emit a particle.
    /// </summary>
    [GameMakerProperty("emitDelayMin")]
    public float DelayMin { get; set; }

    /// <summary>
    /// The time units to use for the delay, see <see cref="TimeUnits"/>.
    /// </summary>
    [GameMakerProperty("emitDelayUnits")]
    public TimeUnits DelayUnits { get; set; }

    /// <summary>
    /// The maximum interval to emit a particle
    /// </summary>
    [GameMakerProperty("emitIntervalMax")]
    public float IntervalMax { get; set; }

    /// <summary>
    /// The minimum interval to emit a particle.
    /// </summary>
    [GameMakerProperty("emitIntervalMin")]
    public float IntervalMin { get; set; }

    /// <summary>
    /// The time units to use for the interval, see <see cref="TimeUnits"/>.
    /// </summary>
    [GameMakerProperty("emitIntervalUnits")]
    public TimeUnits IntervalUnits { get; set; }

    /// <summary>
    /// Whether the Emitter is enabled.
    /// </summary>
    [GameMakerProperty("enabled")]
    public bool IsEnabled { get; set; }

    /// <summary>
    /// The ending color of the particle.
    /// </summary>
    [GameMakerProperty("endColour")]
    public uint EndColor { get; set; }

    /// <summary>
    /// The direction of gravity on the particle.
    /// </summary>
    [GameMakerProperty("gravityDirection")]
    public float GravityDirection { get; set; }

    /// <summary>
    /// The force of gravity on the particle.
    /// </summary>
    [GameMakerProperty("gravityForce")]
    public float Gravity { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("headPosition")]
    public float ImageIndex { get; set; }

    /// <summary>
    /// The maximum lifetime of the particle.
    /// </summary>
    [GameMakerProperty("lifetimeMax")]
    public float LifetimeMax { get; set; }

    /// <summary>
    /// The minimum lifetime of the particle.
    /// </summary>
    [GameMakerProperty("lifetimeMin")]
    public float LifetimeMin { get; set; }

    /// <summary>
    /// The linked Emitter.
    /// </summary>
    [GameMakerProperty("linkedEmitter")]
    public ResourceReference<GMPSEmitter>? LinkedEmitter { get; set; }

    /// <summary>
    /// Whether the emitter is locked.
    /// </summary>
    [GameMakerProperty("locked")]
    public bool IsLocked { get; set; }

    /// <summary>
    /// The midway color of the particle.
    /// </summary>
    [GameMakerProperty("midColour")]
    public uint MidColor { get; set; }

    /// <summary>
    /// The emit mode of the Emitter, see <see cref="EmitMode"/>.
    /// </summary>
    [GameMakerProperty("mode")]
    public EmitMode EmitterMode { get; set; }

    /// <summary>
    /// How much to increase the orientation.
    /// </summary>
    [GameMakerProperty("orientationIncrease")]
    public float OrientationIncrease { get; set; }

    /// <summary>
    /// The maximum orientation of the particle.
    /// </summary>
    [GameMakerProperty("orientationMax")]
    public float OrientationMax { get; set; }

    /// <summary>
    /// The minimum orientation of the particle.
    /// </summary>
    [GameMakerProperty("orientationMin")]
    public float OrientationMin { get; set; }

    /// <summary>
    /// Whether the orientation is relative to the direction.
    /// </summary>
    [GameMakerProperty("orientationRelative")]
    public bool OrientationRelative { get; set; }

    /// <summary>
    /// How much to wiggle the orientation.
    /// </summary>
    [GameMakerProperty("orientationWiggle")]
    public float OrientationWiggle { get; set; }

    /// <summary>
    /// The height of the Emitter.
    /// </summary>
    [GameMakerProperty("regionH")]
    public float RegionH { get; set; }

    /// <summary>
    /// The width of the Emitter.
    /// </summary>
    [GameMakerProperty("regionW")]
    public float RegionW { get; set; }

    /// <summary>
    /// The X position of the Emitter.
    /// </summary>
    [GameMakerProperty("regionX")]
    public float RegionX { get; set; }

    /// <summary>
    /// The Y position of the Emitter.
    /// </summary>
    [GameMakerProperty("regionY")]
    public float RegionY { get; set; }

    /// <summary>
    /// The width of the particle.
    /// </summary>
    [GameMakerProperty("scaleX")]
    public float ScaleX { get; set; }

    /// <summary>
    /// The width of the particle.
    /// </summary>
    [GameMakerProperty("scaleY")]
    public float ScaleY { get; set; }

    /// <summary>
    /// The shape of the Emitter, see <see cref="EmitterShape"/>.
    /// </summary>
    [GameMakerProperty("shape")]
    public EmitterShape Shape { get; set; }

    /// <summary>
    /// How much to increase the size of the particle every frame.
    /// </summary>
    [GameMakerProperty("sizeIncrease")]
    public float SizeIncrease { get; set; }

    /// <summary>
    /// The maximum size of the particle.
    /// </summary>
    [GameMakerProperty("sizeMax")]
    public float SizeMax { get; set; }

    /// <summary>
    /// The minimum size of the particle.
    /// </summary>
    [GameMakerProperty("sizeMin")]
    public float SizeMin { get; set; }

    /// <summary>
    /// How much to wiggle the size of the particle.
    /// </summary>
    [GameMakerProperty("sizeWiggle")]
    public float SizeWiggle { get; set; }

    /// <summary>
    /// The amount of particles to spawn on death.
    /// </summary>
    [GameMakerProperty("spawnOnDeathCount")]
    public int SpawnOnDeathCount { get; set; }

    /// <summary>
    /// The name of the preset to spawn on death.
    /// </summary>
    [GameMakerProperty("spawnOnDeathGMPreset")]
    public string? SpawnOnDeathPreset { get; set; }

    /// <summary>
    /// What Emitter to spawn on death.
    /// </summary>
    [GameMakerProperty("spawnOnDeathId")]
    public ResourceReference<GMPSEmitter>? SpawnOnDeathId { get; set; }

    /// <summary>
    /// The amount of particles to spawn on update.
    /// </summary>
    [GameMakerProperty("spawnOnUpdateCount")]
    public int SpawnOnUpdateCount { get; set; }

    /// <summary>
    /// The name of the preset to spawn on update.
    /// </summary>
    [GameMakerProperty("spawnOnUpdateGMPreset")]
    public string SpawnOnUpdatePreset { get; set; }

    /// <summary>
    /// What Emitter to spawn on update.
    /// </summary>
    [GameMakerProperty("spawnOnUpdateId")]
    public ResourceReference<GMPSEmitter>? SpawnOnUpdateId { get; set; }

    /// <summary>
    /// How much to increase the speed of the particle every frame.
    /// </summary>
    [GameMakerProperty("speedIncrease")]
    public float SpeedIncrease { get; set; }

    /// <summary>
    /// The maximum speed of the particle.
    /// </summary>
    [GameMakerProperty("speedMax")]
    public float SpeedMax { get; set; }

    /// <summary>
    /// The minimum speed of the particle.
    /// </summary>
    [GameMakerProperty("speedMin")]
    public float SpeedMin { get; set; }

    /// <summary>
    /// How much to wiggle the speed of the particle.
    /// </summary>
    [GameMakerProperty("speedWiggle")]
    public float SpeedWiggle { get; set; }

    /// <summary>
    /// Whether to animate the sprite.
    /// </summary>
    [GameMakerProperty("spriteAnimate")]
    public bool DoAnimate { get; set; }

    /// <summary>
    /// The sprite of the Emitter.
    /// </summary>
    [GameMakerProperty("spriteId")]
    public ResourceReference<GMSprite> Sprite { get; set; }

    /// <summary>
    /// Whether to have the frame of the sprite be random.
    /// </summary>
    [GameMakerProperty("spriteRandom")]
    public bool IsRandom { get; set; }

    /// <summary>
    /// Whether to stretch the sprite.
    /// </summary>
    [GameMakerProperty("spriteStretch")]
    public bool IsStretched { get; set; }

    /// <summary>
    /// The starting color of the particle.
    /// </summary>
    [GameMakerProperty("startColour")]
    public uint StartColor { get; set; }

    /// <summary>
    /// The texture type of the particle.
    /// </summary>
    [GameMakerProperty("texture")]
    public ParticleTextureType TextureType { get; set; }
    
    /// <summary>
    /// The emit mode of the Emitter.
    /// </summary>
    public enum EmitMode
    {
        /// <summary>
        /// A consistent stream.
        /// </summary>
        Stream = 0,
        
        /// <summary>
        /// A sudden burst.
        /// </summary>
        Burst = 1,
    }
    
    /// <summary>
    /// The particle distribution of the emitter.
    /// </summary>
    public enum ParticleDistribution
    {
        /// <summary>
        /// Linear distribution.
        /// </summary>
        Linear = 0,
        
        /// <summary>
        /// Gaussian distribution.
        /// </summary>
        Gaussian = 1,
        
        /// <summary>
        /// Inverted gaussian distribution.
        /// </summary>
        InvertedGaussian = 2,
    }
    
    /// <summary>
    /// The shape of the Emitter.
    /// </summary>
    public enum EmitterShape
    {
        /// <summary>
        /// A rectangle.
        /// </summary>
        Rectangle = 0,
        
        // An ellipse shape.
        Ellipse = 1,
        
        /// <summary>
        /// A diamond shape.
        /// </summary>
        Diamond = 2,
        
        /// <summary>
        /// A thin line.
        /// </summary>
        Line = 3,
    }
    
    /// <summary>
    /// The texture type of the particle.
    /// </summary>
    public enum ParticleTextureType
    {
        None = -1,
        Pixel = 0,
        Disk = 1,
        Square = 2,
        Line = 3,
        Star = 4,
        Circle = 5,
        Ring = 6,
        Sphere = 7,
        Flare = 8,
        Spark = 9,
        Explosion = 10,
        Cloud = 11,
        Smoke = 12,
        Snow = 13,
    }
}