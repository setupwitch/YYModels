namespace YYModels.Models;

[YYVersion(2)]
[GMResource("sounds")]
public class GMSound : ResourceBase
{
    /// <summary>
    /// Reference to the audio group.
    /// </summary>
    [GameMakerProperty("audioGroupId")]
    public ResourceReference<GMAudioGroup> AudioGroup { get; set; }

    /// <summary>
    /// Whether the audio is 8 bit or 16 bit, see <see cref="SoundBitDepth"/>.
    /// </summary>
    [GameMakerProperty("bitDepth")]
    public SoundBitDepth BitDepth { get; set; }

    /// <summary>
    /// the channel format of the audio, see <see cref="ChannelFormat"/>.
    /// </summary>
    [GameMakerProperty("channelFormat")]
    public ChannelFormat ChannelType { get; set; }

    /// <summary>
    /// How the audio is compressed.
    /// </summary>
    [GameMakerProperty("compression")]
    public SoundCompression CompressionType { get; set; }

    /// <summary>
    /// the quality of the compression applied.
    /// </summary>
    [GameMakerProperty("compressionQuality")]
    public int CompressionQuality { get; set; }

    /// <summary>
    /// The conversion mode of the audio.
    /// </summary>
    [GameMakerProperty("conversionMode")]
    public SoundConversionMode ConversionMode { get; set; }

    /// <summary>
    /// The length (in seconds) of the audio.
    /// </summary>
    [GameMakerProperty("duration")]
    public float Duration { get; set; }

    /// <summary>
    /// the directory to export the sound to.
    /// </summary>
    [GameMakerProperty("exportDir")]
    public string ExportDirectory { get; set; }

    /// <summary>
    /// Whether the audio should be loaded into memory at the start of the game.
    /// </summary>
    [GameMakerProperty("preload")]
    public bool IsPreloaded { get; set; }

    /// <summary>
    /// The sample rate of the audio./>.
    /// </summary>
    [GameMakerProperty("sampleRate")]
    public int SampleRate { get; set; }

    /// <summary>
    /// The filename of the sound.
    /// </summary>
    /// <example>sounds/soundname.mp3</example>
    [GameMakerProperty("soundFile")]
    public string FileName { get; set; }

    /// <summary>
    /// The volume of the audio.
    /// </summary>
    [GameMakerProperty("volume")]
    public float Volume { get; set; }
    
    /// <summary>
    /// The bit depth of the audio.
    /// </summary>
    public enum SoundBitDepth
    {
        /// <summary>
        /// 8 bits
        /// </summary>
        _8Bit = 0,
        
        /// <summary>
        /// 16 bits
        /// </summary>
        _16Bit = 1,
    }
    
    /// <summary>
    /// The conversion mode of the sound
    /// </summary>
    public enum SoundConversionMode
    {
        /// <summary>
        /// Will convert only when necessary
        /// </summary>
        Automatic = 0,
        
        /// <summary>
        /// Will convert always
        /// </summary>
        Required = 1,
    }
    
    /// <summary>
    /// The compression setting of the sound
    /// </summary>
    public enum SoundCompression
    {
        /// <summary>
        /// The audio is uncompressed, it is embedded in the data file.
        /// </summary>
        Uncompressed = 0,
        
        /// <summary>
        /// The audio is compressed, it is embedded in the data file.
        /// </summary>
        Compressed = 1,
        
        /// <summary>
        /// The audio is compressed and will decompress when loaded, it is embedded in the data file.
        /// </summary>
        DecompressedOnLoad = 2,
        
        /// <summary>
        /// The audio is compressed, it is external from the data file and streamed.
        /// </summary>
        CompressedStreamed = 3,
    }
    
    /// <summary>
    /// The channel format of the audio.
    /// </summary>
    public enum ChannelFormat
    {
        /// <summary>
        /// One channel
        /// </summary>
        Mono = 0,
        
        /// <summary>
        /// Two channels
        /// </summary>
        Stereo = 1,
        
        /// <summary>
        /// Three channels (or more?)
        /// </summary>
        _3D = 2,
    }
}