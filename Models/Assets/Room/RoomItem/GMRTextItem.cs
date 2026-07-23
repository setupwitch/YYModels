namespace YYModels.Models;

/// <summary>
/// A text item in a <see cref="GMRAssetLayer"/>.
/// </summary>
[YYVersion(3)]
public class GMRTextItem : GMRItem
{
    /// <summary>
    /// The alignment of the text.
    /// </summary>
    [GameMakerProperty("alignment")]
    public int TextAlignment { get; set; }

    /// <summary>
    /// The character spacing of the text.
    /// </summary>
    [GameMakerProperty("charSpacing")]
    public float CharacterSpacing { get; set; }

    /// <summary>
    /// The color of the text.
    /// </summary>
    [GameMakerProperty("colour")]
    public uint Color { get; set; }

    /// <summary>
    /// A reference to the font.
    /// </summary>
    [GameMakerProperty("fontId")]
    public ResourceReference<GMFont> Font { get; set; }

    /// <summary>
    /// The height of the frame.
    /// </summary>
    [GameMakerProperty("frameH")]
    public float FrameHeight { get; set; }

    /// <summary>
    /// The width of the frame.
    /// </summary>
    [GameMakerProperty("frameW")]
    public float FrameWidth { get; set; }

    /// <summary>
    /// The line spacing of the text.
    /// </summary>
    [GameMakerProperty("lineSpacing")]
    public float LineSpacing { get; set; }

    /// <summary>
    /// The paragraph spacing of the text.
    /// </summary>
    [GameMakerProperty("paragraphSpacing")]
    public float ParagraphSpacing { get; set; }

    /// <summary>
    /// The rotation of the text.
    /// </summary>
    [GameMakerProperty("rotation")]
    public float Rotation { get; set; }

    /// <summary>
    /// The X scale of the text.
    /// </summary>
    [GameMakerProperty("scaleX")]
    public float ScaleX { get; set; }

    /// <summary>
    /// The Y scale of the text.
    /// </summary>
    [GameMakerProperty("scaleY")]
    public float ScaleY { get; set; }

    /// <summary>
    /// The text contents.
    /// </summary>
    [GameMakerProperty("text")]
    public string TextContents { get; set; }

    /// <summary>
    /// Whether to wrap the text.
    /// </summary>
    [GameMakerProperty("wrap")]
    public bool IsWrapped { get; set; }

    /// <summary>
    /// The X origin of the text.
    /// </summary>
    [GameMakerProperty("xorigin")]
    public float OriginX { get; set; }

    /// <summary>
    /// The Y origin of the text.
    /// </summary>
    [GameMakerProperty("yorigin")]
    public float OriginY { get; set; }
}