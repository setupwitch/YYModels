namespace YYModels.Models;

/// <summary>
/// Nine Slice data for the sprite.
/// </summary>
[YYVersion(0)]
public class GMNineSliceData : ResourceBase
{
    /// <summary>
    /// How much to trim from the bottom.
    /// </summary>
    [GameMakerProperty("bottom")]
    public int BottomTrim { get; set; }

    /// <summary>
    /// Whether Nine Slice is enabled.
    /// </summary>
    [GameMakerProperty("enabled")]
    public bool IsEnabled { get; set; }

    /// <summary>
    /// The guide color for the Nine Slice editor.
    /// </summary>
    [GameMakerProperty("guideColour")]
    public List<uint> EditorColor { get; set; }

    /// <summary>
    /// Unknown, related to <see cref="EditorColor"/>?
    /// </summary>
    [GameMakerProperty("highlightColour")]
    public uint EditorHighlightColor { get; set; }

    /// <summary>
    /// The highlight style of the Nine Slice data, see <see cref="HighlightStyle"/>.
    /// </summary>
    [GameMakerProperty("highlightStyle")]
    public HighlightStyle EditorHighlightStyle { get; set; }

    /// <summary>
    /// How much to trim from the left.
    /// </summary>
    [GameMakerProperty("left")]
    public int LeftTrim { get; set; }

    /// <summary>
    /// How much to trim from the right.
    /// </summary>
    [GameMakerProperty("right")]
    public int RightTrim { get; set; }

    /// <summary>
    /// The tile modes of the sprite.
    /// </summary>
    [GameMakerProperty("tileMode")]
    public List<TileMode> TileModes { get; set; }

    /// <summary>
    /// How much to trim from the top.
    /// </summary>
    [GameMakerProperty("top")]
    public int TopTrim { get; set; }

    /// <summary>
    /// The highlight style of the Nine Slice data.
    /// </summary>
    public enum HighlightStyle
    {
        /// <summary>
        /// Inverse the selection.
        /// </summary>
        Inverse,

        /// <summary>
        /// Overlay the selection.
        /// </summary>
        Overlay,
    }
    
    /// <summary>
    /// The tile mode of the Nine Slice data.
    /// </summary>
    public enum TileMode
    {
        /// <summary>
        /// Stretch the sprite.
        /// </summary>
        Stretched,
        
        /// <summary>
        /// Repeat the sprite.
        /// </summary>
        Repeat,
        
        /// <summary>
        /// Mirror the sprite.
        /// </summary>
        Mirror,
        
        /// <summary>
        /// Do a blank repeat on the sprite.
        /// </summary>
        RepeatBlank,
        
        /// <summary>
        /// Hide the sprite.
        /// </summary>
        Hide,
    }
}