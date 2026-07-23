namespace YYModels.Models;

public class AudioEffectParam
{
    /// <summary>
    /// The current value for the effect.
    /// </summary>
    [GameMakerProperty("CurrentValue")]
    public double CurrentValue { get; set; }

    /// <summary>
    /// The default value for the effect.
    /// </summary>
    [GameMakerProperty("DefaultValue")]
    public double DefaultValue { get; set; }

    /// <summary>
    /// The type of the effect.
    /// </summary>
    [GameMakerProperty("EffectType")]
    public AudioEffectType EffectType { get; set; }

    /// <summary>
    /// The maximum value for the effect.
    /// </summary>
    [GameMakerProperty("MaxValue")]
    public double MaxValue { get; set; }

    /// <summary>
    /// The minimum value of the effect.
    /// </summary>
    [GameMakerProperty("MinValue")]
    public double MinValue { get; set; }

    /// <summary>
    /// The name of the effect.
    /// </summary>
    [GameMakerProperty("Name")]
    public string Name { get; set; }

    /// <summary>
    /// The value type of the effect.
    /// </summary>
    [GameMakerProperty("ValueType")]
    public AudioEffectValueType ValueType { get; set; }

    public enum AudioEffectType
    {
        Bitcrusher = 0,
        Delay = 1, 
        Gain = 2, 
        HighPassFilter = 3, 
        LowPassFilter = 4, 
        Reverb = 5,
        Tremolo = 6, 
        PeakEQ = 7, 
        Hishelf = 8, 
        Loshelf = 9, 
        EQ = 10, 
        Compressor = 11,
        Bus = 12, 
    }
    
    public enum AudioEffectValueType
    {
        Float = 0,
        Int = 1,
        Bool = 2,
    }
}

/// <remarks>Unused</remarks>
[YYVersion(0)]
public class GMAudioEffect : ResourceBase
{
    
}

/// <remarks>Unused</remarks>
[YYVersion(0)]
public class GMAudioEmitter : ResourceBase
{
    
}