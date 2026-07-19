namespace YYModels.Models;

public partial class GMSequence
{
    /// <summary>
    /// A KeyframeStore in a sequence.
    /// </summary>
    /// <remarks>Version 1</remarks>
    /// <typeparam name="T">A keyframe class</typeparam>
    /// <example><see cref="Models.GMSequence.AssetKeyframe"/>, <see cref="Models.GMSequence.AnimCurveKeyframe"/></example>
    public class KeyframeStore<T> : ResourceBase
    {
        /// <summary>
        /// The list of keyframes in the KeyframeStore.
        /// </summary>
        [GameMakerProperty("Keyframes")]
        public List<Keyframe<T>> Keyframes { get; set; }
    }

    /// <summary>
    /// A Keyframe in a sequence.
    /// </summary>
    /// <remarks>Version 0</remarks>
    /// <typeparam name="T">A keyframe class</typeparam>
    /// <example><see cref="Models.GMSequence.AssetKeyframe"/>, <see cref="Models.GMSequence.AnimCurveKeyframe"/></example>
    public class Keyframe<T> : ResourceBase
    {
        /// <summary>
        /// The channels in the keyframe.
        /// </summary>
        [GameMakerProperty("Channels")]
        public Dictionary<string, T> Channels { get; set; }

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
    
    /// <remarks>Version 0</remarks>
    public class BoolKeyframe : ResourceBase
    {
        /// <summary>
        /// The boolean value for the keyframe.
        /// </summary>
        [GameMakerProperty("Value")]
        public bool Value { get; set; }
    }
    
    /// <remarks>Version 0</remarks>
    public class MessageEventKeyframe : ResourceBase
    {
        /// <summary>
        /// The messages in the keyframe.
        /// </summary>
        [GameMakerProperty("Events")]
        public List<string> Events { get; set; }
    }
    
    /// <remarks>Version 0</remarks>
    public class MomentsEventKeyframe : MessageEventKeyframe
    {
        
    }
    
    /// <remarks>Version 0</remarks>
    public class AssetKeyframe : ResourceBase
    {
        /// <summary>
        /// A refernece to the asset in the keyframe.
        /// </summary>
        [GameMakerProperty("Id")]
        public ResourceReference<GMSprite> Asset { get; set; }
    }
    
    /// <remarks>Version 0</remarks>
    public class AssetInstanceKeyframe : AssetKeyframe
    {

    }
    
    /// <remarks>Version 0</remarks>
    public class AssetSequenceKeyframe : AssetKeyframe
    {
        
    }
    
    /// <remarks>Version 0</remarks>
    public class AssetParticleSystemKeyframe : AssetKeyframe
    {
        
    }
    
    /// <remarks>Version 0</remarks>
    public class AssetSpriteKeyframe : AssetKeyframe
    {

    }
    
    /// <remarks>Version 0</remarks>
    public class SpriteFrameKeyframe : AssetKeyframe
    {

    }
    
    /// <remarks>Version 1</remarks>
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
        
        public enum TextWrapMode
        {
            Default = 0,
            Split = 1,
        }
    }
    
    /// <remarks>Version 0</remarks>
    public class StringKeyframe : ResourceBase
    {
        /// <summary>
        /// The string value in they keyframe.
        /// </summary>
        [GameMakerProperty("String")]
        public string String { get; set; }
    }
    
    /// <remarks>Version 0</remarks>
    public class AudioKeyframe : AssetKeyframe
    {
        /// <summary>
        /// The sound mode in the keyframe.
        /// </summary>
        [GameMakerProperty("Mode")]
        public SoundMode Mode { get; set; }
    }
    
    /// <remarks>Unused</remarks>
    /// <remarks>Version 0</remarks>
    public class CodeKeyframe : AssetKeyframe
    {
        
    }
    
    /// <remarks>Version 0</remarks>
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
    
    /// <remarks>Version 0</remarks>
    public class RealKeyframe : AnimCurveKeyframe
    {
        /// <summary>
        /// The float value in the keyframe.
        /// </summary>
        [GameMakerProperty("RealValue")]
        public float Value { get; set; }
    }

    /// <remarks>Version 0</remarks>
    public class AudioEffectKeyframe : AnimCurveKeyframe
    {
        /// <summary>
        /// The audio parameter value in the keyframe.
        /// </summary>
        [GameMakerProperty("Parameter")]
        public AudioEffectParam? Parameter { get; set; }
    }
    
    /// <remarks>Version 0</remarks>
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