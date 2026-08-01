namespace YYModels.Models;

public partial class GMSequence
{
    /// <summary>
    /// A KeyframeStore in a sequence.
    /// </summary>
    /// <typeparam name="T">A keyframe class</typeparam>
    /// <example><see cref="Models.GMSequence.AssetKeyframe"/>, <see cref="Models.GMSequence.AnimCurveKeyframe"/></example>
    [YYVersion(0)]
    public class KeyframeStore<T> : ResourceBase
    {
        [GameMakerIgnore]
        public new string Name { get; set; }
        
        [GameMakerIgnore]
        public new string ResourceName { get; set; }
        
        /// <summary>
        /// Overwrites <see cref="ResourceBase.LegacyResourceType"/> to fix generics.
        /// </summary>
        [GameMakerProperty("resourceType")]
        public new string LegacyResourceType => this.GetType().Name.Replace("`1", $"<{typeof(T).Name}>");
        
        /// <summary>
        /// The list of keyframes in the KeyframeStore.
        /// </summary>
        [GameMakerProperty("Keyframes")]
        public List<Keyframe<T>> Keyframes { get; set; } = new();
    }

    /// <summary>
    /// A Keyframe in a sequence.
    /// </summary>
    /// <typeparam name="T">A keyframe class</typeparam>
    /// <example><see cref="Models.GMSequence.AssetKeyframe"/>, <see cref="Models.GMSequence.AnimCurveKeyframe"/></example>
    [YYVersion(0)]
    
    public class Keyframe<T> : ResourceBase
    {
        /// <summary>
        /// Overwrites <see cref="ResourceBase.LegacyResourceType"/> to fix generics.
        /// </summary>
        [GameMakerProperty("resourceType")]
        public new string LegacyResourceType => this.GetType().Name.Replace("`1", $"<{typeof(T).Name}>");
        
        /// <summary>
        /// The channels in the keyframe.
        /// </summary>
        [GameMakerProperty("Channels")]
        public Dictionary<string, T> Channels { get; set; } = new();

        /// <summary>
        /// Whether the keyframe is disabled or not.
        /// </summary>
        [GameMakerProperty("Disabled")]
        public bool Disabled { get; set; }

        /// <summary>
        /// Unknown.
        /// </summary>
        [GameMakerProperty("IsCreationKey")]
        public bool IsCreationKey { get; set; }

        /// <summary>
        /// The current key for the keyframe.
        /// </summary>
        [GameMakerProperty("Key")]
        public float Key { get; set; }

        /// <summary>
        /// The length of the keyframe.
        /// </summary>
        [GameMakerProperty("Length")]
        public float Length { get; set; }

        /// <summary>
        /// Unknown meaning.
        /// </summary>
        [GameMakerProperty("Stretch")]
        public bool Stretch { get; set; }

        /// <summary>
        /// A Guid for the keyframe.
        /// </summary>
        [GameMakerProperty("id")]
        public Guid Guid { get; set; }
    }
    
    [YYVersion(0)]
    public class BoolKeyframe : ResourceBase
    {
        /// <summary>
        /// The boolean value for the keyframe.
        /// </summary>
        [GameMakerProperty("Value")]
        public bool Value { get; set; }
    }
    
    [YYVersion(0)]
    public class MessageEventKeyframe : ResourceBase
    {
        /// <summary>
        /// The messages in the keyframe.
        /// </summary>
        [GameMakerProperty("Events")]
        public List<string> Events { get; set; } = new();
    }
    
    [YYVersion(0)]
    public class MomentsEventKeyframe : MessageEventKeyframe
    {
        
    }
    
    [YYVersion(0)]
    public class AssetKeyframe : ResourceBase
    {
        /// <summary>
        /// A refernece to the asset in the keyframe.
        /// </summary>
        [GameMakerProperty("Id")]
        public ResourceReference<GMSprite> Asset { get; set; }
    }
    
    [YYVersion(0)]
    public class AssetInstanceKeyframe : AssetKeyframe
    {
        [GameMakerProperty("Id")]
        public ResourceReference<GMObject> Asset { get; set; }
    }
    
    [YYVersion(0)]
    public class AssetSequenceKeyframe : AssetKeyframe
    {
        [GameMakerProperty("Id")]
        public ResourceReference<GMSequence> Asset { get; set; }
    }
    
    [YYVersion(0)]
    public class AssetParticleSystemKeyframe : AssetKeyframe
    {
        [GameMakerProperty("Id")]
        public ResourceReference<GMParticleSystem> Asset { get; set; }
    }
    
    [YYVersion(0)]
    public class AssetSpriteKeyframe : AssetKeyframe
    {
        [GameMakerProperty("Id")]
        public ResourceReference<GMSprite> Asset { get; set; }
    }
    
    [YYVersion(0)]
    public class SpriteFrameKeyframe : AssetKeyframe
    {
        [GameMakerProperty("Id")]
        public ResourceReference<GMSprite> Asset { get; set; }
    }
    
    [YYVersion(1)]
    public class AssetTextKeyframe : AssetKeyframe
    {
        /// <summary>
        /// The alignment of the text.
        /// </summary>
        [GameMakerProperty("Alignment")]
        public int Alignment { get; set; }

        /// <summary>
        /// Whether SDF effects are enabled.
        /// </summary>
        [GameMakerProperty("EnableEffects")]
        public bool EnableEffects { get; set; }

        /// <summary>
        /// Whether SDF glow is enabled.
        /// </summary>
        [GameMakerProperty("EnableGlow")]
        public bool EnableGlow { get; set; }

        /// <summary>
        /// Whether SDF outline is enabled.
        /// </summary>
        [GameMakerProperty("EnableOutline")]
        public bool EnableOutline { get; set; }

        /// <summary>
        /// Whether SDF shadow is enabled.
        /// </summary>
        [GameMakerProperty("EnableShadow")]
        public bool EnableShadow { get; set; }

        /// <summary>
        /// The origin point of the text.
        /// </summary>
        [GameMakerProperty("Origin")]
        public Origin Origin { get; set; }

        /// <summary>
        /// The text contents in the keyframe.
        /// </summary>
        [GameMakerProperty("Text")]
        public string Text { get; set; }

        /// <summary>
        /// Whether to wrap the text.
        /// </summary>
        [GameMakerProperty("Wrap")]
        public bool Wrap { get; set; }

        /// <summary>
        /// Determines the wrapping type of the text.
        /// </summary>
        [GameMakerProperty("WrapMode")]
        public TextWrapMode WrapMode { get; set; }
        
        [GameMakerProperty("Id")]
        public ResourceReference<GMFont> Asset { get; set; }
        
        public enum TextWrapMode
        {
            Default = 0,
            Split = 1,
        }
    }
    
    [YYVersion(0)]
    public class StringKeyframe : ResourceBase
    {
        /// <summary>
        /// The string value in they keyframe.
        /// </summary>
        [GameMakerProperty("String")]
        public string String { get; set; }
    }
    
    [YYVersion(0)]
    public class AudioKeyframe : AssetKeyframe
    {
        /// <summary>
        /// The sound mode in the keyframe.
        /// </summary>
        [GameMakerProperty("Mode")]
        public SoundMode Mode { get; set; }
        
        [GameMakerProperty("Id")]
        public ResourceReference<GMSound> Asset { get; set; }
    }
    
    /// <remarks>Unused</remarks>
    [YYVersion(0)]
    public class CodeKeyframe : AssetKeyframe
    {
        [GameMakerProperty("Id")]
        public ResourceReference<GMScript> Asset { get; set; }
    }
    
    [YYVersion(0)]
    public class AnimCurveKeyframe : ResourceBase
    {
        /// <summary>
        /// A reference to the animation curve in the keyframe.
        /// </summary>
        [GameMakerProperty("AnimCurveId")]
        public ResourceReference<GMAnimCurve>? AnimationCurve { get; set; }

        /// <summary>
        /// A <see cref="GMAnimCurve"/> embedded into the keyframe.
        /// </summary>
        [GameMakerProperty("EmbeddedAnimCurve")]
        public GMAnimCurve? EmbeddedAnimationCurve { get; set; }
    }
    
    [YYVersion(0)]
    public class RealKeyframe : AnimCurveKeyframe
    {
        /// <summary>
        /// The float value in the keyframe.
        /// </summary>
        [GameMakerProperty("RealValue")]
        public float Value { get; set; }
    }

    [YYVersion(0)]
    public class AudioEffectKeyframe : AnimCurveKeyframe
    {
        /// <summary>
        /// The audio parameter value in the keyframe.
        /// </summary>
        [GameMakerProperty("Parameter")]
        public AudioEffectParam? Parameter { get; set; }
    }
    
    [YYVersion(0)]
    public class ColourKeyframe : AnimCurveKeyframe
    {
        /// <summary>
        /// The color value in the keyframe.
        /// </summary>
        [GameMakerProperty("Colour")]
        public uint Color { get; set; }
    }
    
    public enum SoundMode
    {
        Single = 0,
        Looping = 1,
    }
}