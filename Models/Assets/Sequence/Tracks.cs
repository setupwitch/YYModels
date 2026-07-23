namespace YYModels.Models;

public partial class GMSequence
{
    [YYVersion(0)]
    public class GMBaseTrack : ResourceBase
    {
        /// <summary>
        /// The number ID of the track.
        /// </summary>
        [GameMakerProperty("builtinName")]
        public BuiltinTrack BuiltinName { get; set; }

        /// <summary>
        /// The events in the track.
        /// </summary>
        [GameMakerProperty("events")]
        public List<GMEvent> Events { get; set; }

        /// <summary>
        /// Whether to inherit the color from the parent track.
        /// </summary>
        [GameMakerProperty("inheritsTrackColour")]
        public bool InheritsTrackColour { get; set; }

        /// <summary>
        /// The interpolation mode of the track.
        /// </summary>
        [GameMakerProperty("interpolation")]
        public InterpolationMode Interpolation { get; set; }

        /// <summary>
        /// Unknown.
        /// </summary>
        [GameMakerProperty("isCreationTrack")]
        public bool IsCreationTrack { get; set; }

        /// <summary>
        /// The modifiers in the track.
        /// </summary>
        [GameMakerProperty("modifiers")]
        public List<IModifier> Modifiers { get; set; }

        /// <summary>
        /// The current color of the track.
        /// </summary>
        [GameMakerProperty("trackColour")]
        public uint TrackColor { get; set; }

        /// <summary>
        /// The child tracks.
        /// </summary>
        [GameMakerProperty("tracks")]
        public List<GMBaseTrack> Tracks { get; set; }

        /// <summary>
        /// The traits of the track.
        /// </summary>
        [GameMakerProperty("traits")]
        public TrackTraits Traits { get; set; }

        public enum InterpolationMode
        {
            None = 0,
            Linear = 1,
        }

        public enum TrackTraits
        {
            None = 0,
            IgnoreOrigin = 1,
        }

        public enum BuiltinTrack
        {
            None = -1,
            UserDefined = 0,
            X = 1,
            Y = 2,
            ScaleX = 3,
            ScaleY = 4,
            Gain = 5,
            Pitch = 6,
            Falloff = 7,
            Rotation = 8,
            BlendAdd = 9,
            BlendMultiply = 10,
            ClippingMask = 11,
            Mask = 12,
            Subject = 13,
            Position = 14,
            Scale = 15,
            Origin = 16,
            ImageSpeed = 17,
            ImageIndex = 18,
            Group = 19,
            FrameSize = 20,
            CharacterSpacing = 21,
            LineSpacing = 22,
            ParagraphSpacing = 23,
            TextThickness = 24,
            TextCoreColour = 25,
            TextGlowStart = 26,
            TextGlowEnd = 27,
            TextGlowColour = 28,
            TextOutlineDistance = 29,
            TextOutlineColour = 30,
            TextShadowSoftness = 31,
            TextShadowOffset = 32,
            TextShadowColour = 33,
            AudioBus = 34,
            AudioBitcrusher = 35,
            AudioCompressor = 36,
            AudioDelay = 37,
            AudioGain = 38,
            AudioHishelf = 39,
            AudioHPF2 = 40,
            AudioLoshelf = 41,
            AudioLPF2 = 42,
            AudioPeakEQ = 43,
            AudioReverb1 = 44,
            AudioTremolo = 45,
        }
    }
    
    [YYVersion(0)]
    public class GMGraphicTrack : GMBaseTrack
    {
        /// <summary>
        /// The <see cref="KeyframeStore{AssetSpriteKeyFrame}"/> in the track.
        /// </summary>
        [GameMakerProperty("keyframes")]
        public KeyframeStore<AssetSpriteKeyframe> Keyframes { get; set; }
    }
    
    [YYVersion(0)]
    public class GMSequenceTrack : GMBaseTrack
    {
        /// <summary>
        /// The <see cref="KeyframeStore{AssetSequenceKeyframe}"/> in the track.
        /// </summary>
        [GameMakerProperty("keyframes")]
        public KeyframeStore<AssetSequenceKeyframe> Keyframes { get; set; }
    }
    
    [YYVersion(0)]
    public class GMSpriteFramesTrack : GMBaseTrack
    {
        /// <summary>
        /// The <see cref="KeyframeStore{SpriteFrameKeyframe}"/> in the track.
        /// </summary>
        [GameMakerProperty("keyframes")]
        public KeyframeStore<SpriteFrameKeyframe> Keyframes { get; set; }

        /// <summary>
        /// The sprite reference in the track.
        /// </summary>
        [GameMakerProperty("spriteId")]
        public ResourceReference<GMSprite>? Sprite { get; set; }
    }
    
    [YYVersion(0)]
    public class GMComponentTrack : GMBaseTrack
    {
        
    }
    
    [YYVersion(0)]
    public class GMClipMaskTrack : GMComponentTrack
    {
        
    }
    
    [YYVersion(0)]
    public class GMGroupTrack : GMComponentTrack
    {
        
    }
    
    [YYVersion(0)]
    public class GMClipMask_Mask : GMGroupTrack
    {
        
    }
    
    [YYVersion(0)]
    public class GMClipMask_Subject : GMGroupTrack
    {
        
    }

    [YYVersion(0)]
    public class GMParameterTrack : GMBaseTrack
    {
        
    }
    
    [YYVersion(0)]
    public class GMStringTrack : GMParameterTrack
    {
        /// <summary>
        /// The <see cref="KeyframeStore{StringKeyframe}"/> in the track.
        /// </summary>
        [GameMakerProperty("keyframes")]
        public KeyframeStore<StringKeyframe> Keyframes { get; set; }
    }
    
    [YYVersion(0)]
    public class GMRealTrack : GMParameterTrack
    {
        /// <summary>
        /// The <see cref="KeyframeStore{RealKeyframe}"/> in the track.
        /// </summary>
        [GameMakerProperty("keyframes")]
        public KeyframeStore<RealKeyframe> Keyframes { get; set; }
    }
    
    [YYVersion(0)]
    public class GMAudioEffectTrack : GMParameterTrack
    {
        /// <summary>
        /// The <see cref="KeyframeStore{AudioEffectKeyframe}"/> in the track.
        /// </summary>
        [GameMakerProperty("keyframes")]
        public KeyframeStore<AudioEffectKeyframe> Keyframes { get; set; }
    }
    
    /// <remarks>Unused</remarks>
    [YYVersion(0)]
    public class GMCodeTrack : GMResourceTrack
    {
        /// <summary>
        /// The <see cref="KeyframeStore{CodeKeyframe}"/> in the track.
        /// </summary>
        [GameMakerProperty("keyframes")]
        public KeyframeStore<CodeKeyframe> Keyframes { get; set; }
    }
    
    [YYVersion(0)]
    public class GMColourTrack : GMParameterTrack
    {
        /// <summary>
        /// The <see cref="KeyframeStore{ColourKeyframe}"/> in the track.
        /// </summary>
        [GameMakerProperty("keyframes")]
        public KeyframeStore<ColourKeyframe> Keyframes { get; set; }
    }
    
    [YYVersion(0)]
    public class GMBoolTrack : GMParameterTrack
    {
        /// <summary>
        /// The <see cref="KeyframeStore{BoolKeyframe}"/> in the track.
        /// </summary>
        [GameMakerProperty("keyframes")]
        public KeyframeStore<BoolKeyframe> Keyframes { get; set; }
    }
    
    [YYVersion(0)]
    public class GMResourceTrack : GMBaseTrack
    {
        
    }
    
    [YYVersion(0)]
    public class GMTextTrack : GMResourceTrack
    {
        /// <summary>
        /// The <see cref="KeyframeStore{AssetTextKeyframe}"/> in the track.
        /// </summary>
        [GameMakerProperty("keyframes")]
        public KeyframeStore<AssetTextKeyframe> Keyframes { get; set; }
    }
    
    [YYVersion(0)]
    public class GMInstanceTrack : GMResourceTrack
    {
        /// <summary>
        /// The <see cref="KeyframeStore{AssetInstanceKeyframe}"/> in the track.
        /// </summary>
        [GameMakerProperty("keyframes")]
        public KeyframeStore<AssetInstanceKeyframe> Keyframes { get; set; }
    }
    
    [YYVersion(0)]
    public class GMParticleTrack : GMResourceTrack
    {
        /// <summary>
        /// The <see cref="KeyframeStore{AssetParticleSystemKeyframe}"/> in the track.
        /// </summary>
        [GameMakerProperty("keyframes")]
        public KeyframeStore<AssetParticleSystemKeyframe> Keyframes { get; set; }
    }
    
    [YYVersion(0)]
    public class GMAudioTrack : GMResourceTrack
    {
        /// <summary>
        /// The <see cref="KeyframeStore{AudioKeyframe}"/> in the track.
        /// </summary>
        [GameMakerProperty("keyframes")]
        public KeyframeStore<AudioKeyframe> Keyframes { get; set; }
    }
}