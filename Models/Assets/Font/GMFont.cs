namespace YYModels.Models;

[YYVersion(0)]
[GMResource("fonts")]
public class GMFont : ResourceBase
{
    /// <summary>
    /// The Anti-Alias mode for the font.
    /// </summary>
    [GameMakerProperty("AntiAlias")]
    public FontAntiAliasing AntiAliasMode { get; set; }

    /// <summary>
    /// The name of the TTF file.
    /// </summary>
    [GameMakerProperty("TTFName")]
    public string TTFName { get; set; }

    /// <summary>
    /// Whether to apply kerning to the rendered font.
    /// </summary>
    [GameMakerProperty("applyKerning")]
    public FontKerning Kerning { get; set; }

    /// <summary>
    /// Typography shenanigans for glyph Y position.
    /// </summary>
    [GameMakerProperty("ascender")]
    public int Ascender { get; set; }

    /// <summary>
    /// Typography shenanigans for glyph Y offset.
    /// </summary>
    [GameMakerProperty("ascenderOffset")]
    public int AscenderOffset { get; set; }

    /// <summary>
    /// Whether the font is bold or not.
    /// </summary>
    [GameMakerProperty("bold")]
    public bool IsBold { get; set; }

    /// <summary>
    /// Whether the font texture can be re-rendered.
    /// </summary>
    [GameMakerProperty("canGenerateBitmap")]
    public bool CanGenerateBitmap { get; set; }

    /// <summary>
    /// Unknown
    /// </summary>
    [GameMakerProperty("charset")]
    public int Charset { get; set; }

    /// <summary>
    /// The start of the character range.
    /// </summary>
    [GameMakerProperty("first")]
    public int StartCharacter { get; set; }

    /// <summary>
    /// The name of the font.
    /// </summary>
    [GameMakerProperty("fontName")]
    public string FontName { get; set; }

    /// <summary>
    /// Flags for how the font renders.
    /// </summary>
    [GameMakerProperty("glyphOperations")]
    public FontGlyphFlags GlyphOperations { get; set; }

    /// <summary>
    /// The <see cref="Glyph"/>s of the font.
    /// </summary>
    [GameMakerProperty("glyphs")]
    public Dictionary<int, FontGlyph> Glyphs { get; set; }

    /// <summary>
    /// Hinting for the font, see <see cref="FontHinting"/>.
    /// </summary>
    [GameMakerProperty("hinting")]
    public FontHinting HintingStyle { get; set; }

    /// <summary>
    /// Whether to include the font's TTF file.
    /// </summary>
    [GameMakerProperty("includeTTF")]
    public bool IncludeTTFFile { get; set; }

    /// <summary>
    /// The interpreter of the font, can be TrueType35 or TrueType40.
    /// </summary>
    [GameMakerProperty("interpreter")]
    public FontInterpreter Interpreter { get; set; }

    /// <summary>
    /// Whether the font is italic or not.
    /// </summary>
    [GameMakerProperty("italic")]
    public bool IsItalic { get; set; }

    /// <summary>
    /// font character spacing info
    /// </summary>
    [GameMakerProperty("kerningPairs")]
    public List<KerningPair> KerningPairs { get; set; }

    /// <summary>
    /// The end of the character range.
    /// </summary>
    [GameMakerProperty("last")]
    public int EndCharacter { get; set; }

    /// <summary>
    /// Unknown, most likely helper information for the font renderer.
    /// </summary>
    [GameMakerProperty("lineHeight")]
    public int LineHeight { get; set; }

    /// <summary>
    /// Whether to act like a GMS1 font.
    /// </summary>
    [GameMakerProperty("maintainGms1Font")]
    public bool IsLegacy { get; set; }

    /// <summary>
    /// Point rounding for the font.
    /// </summary>
    [GameMakerProperty("pointRounding")]
    public FontRounding Rounding { get; set; }

    /// <summary>
    /// Ranges of the font
    /// </summary>
    [GameMakerProperty("ranges")]
    public List<FontRange> Ranges { get; set; }

    /// <summary>
    /// Unknown always false, probably will regenerate the font on load?
    /// </summary>
    [GameMakerProperty("regenerateBitmap")]
    public bool DoRegenerateBitmap { get; set; }

    /// <summary>
    /// The sample text for the font.
    /// </summary>
    [GameMakerProperty("sampleText")]
    public string SampleText { get; set; }

    /// <summary>
    /// How much the font effects can spread from the glyphs edge.
    /// </summary>
    [GameMakerProperty("sdfSpread")]
    public int SDFSpread { get; set; }

    /// <summary>
    /// The size of the font.
    /// </summary>
    [GameMakerProperty("size")]
    public float Size { get; set; }

    /// <summary>
    /// The name of the font style.
    /// </summary>
    [GameMakerProperty("styleName")]
    public string StyleName { get; set; }

    /// <summary>
    /// A reference to the <see cref="GMProject.GMTextureGroup"/>
    /// </summary>
    [GameMakerProperty("textureGroupId")]
    public ResourceReference<GMTextureGroup> TextureGroup { get; set; }

    /// <summary>
    /// Whether the font is an SDF font or not.
    /// </summary>
    [GameMakerProperty("usesSDF")]
    public bool UsesSDFRendering { get; set; }
    
    /// <summary>
    /// The hinting of the font, used for the font renderer.
    /// </summary>
    public enum FontHinting
    {
        /// <summary>
        /// Allows for antialiasing.
        /// </summary>
        Normal = 0,
        
        /// <summary>
        /// Disables antialiasing.
        /// </summary>
        Monochrome = 1,
        
        /// <summary>
        /// Lighter antialiasing.
        /// </summary>
        Light = 2,
    }
    
    /// <summary>
    /// Flags for the renderer.
    /// </summary>
    [Flags]
    public enum FontGlyphFlags
    {
        /// <summary>
        /// None.
        /// </summary>
        Default = 0,
        
        /// <summary>
        /// Disable the font hinter when rendering.
        /// </summary>
        DisableHinting = 1,
        
        /// <summary>
        /// Disable the auto-hinter and prefer the native one.
        /// </summary>
        DisableAutoHinter = 2,
        
        /// <summary>
        /// Disable the native hinter and prefer the auto-hinter.
        /// </summary>
        PreferAutoHinter = 4,
        
        /// <summary>
        /// Unknown.
        /// </summary>
        Unknown = 8,
        
        /// <summary>
        /// Ignore the font size.
        /// </summary>
        NoScale = 16,
    }
    
    /// <summary>
    /// The font interpreter to use for rendering.
    /// </summary>
    public enum FontInterpreter
    {
        /// <summary>
        /// Use TrueType40.
        /// </summary>
        TrueType40 = 0,
        
        /// <summary>
        /// Use TrueType35.
        /// </summary>
        TrueType35 = 1,
    }
    
    /// <summary>
    /// How to round the points of the font.
    /// </summary>
    public enum FontRounding
    {
        /// <summary>
        /// <see cref="Math.Floor(decimal)"/>
        /// </summary>
        Floored = 0,
        
        /// <summary>
        /// <see cref="Math.Round(decimal)"/>
        /// </summary>
        Rounded = 1,
        
        /// <summary>
        /// <see cref="Math.Ceiling(decimal)"/>
        /// </summary>
        Ceiling = 2,
    }
    
    /// <summary>
    /// Whether to apply kerning to the font.
    /// </summary>
    public enum FontKerning
    {
        /// <summary>
        /// Apply kerning.
        /// </summary>
        On = 0,
        
        /// <summary>
        /// Do not apply kerning.
        /// </summary>
        Off = 1,
    }
    
    /// <summary>
    /// The antialias mode of the font.
    /// </summary>
    public enum FontAntiAliasing
    {
        /// <summary>
        /// No anti aliasing.
        /// </summary>
        Monochrome = 0,
        
        /// <summary>
        /// Normal anti aliasing.
        /// </summary>
        Normal = 1,
    }
    
}