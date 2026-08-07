namespace YYModels.Models;

/// <summary>
/// An interface for fill styles.
/// </summary>
[YYVersion(0)]
[GameMakerKeyPolymorphic]
[GameMakerDerivedType(typeof(SolidFillStyleData), "$1")]
[GameMakerDerivedType(typeof(GradientFillStyleData), "$2")]
[GameMakerDerivedType(typeof(LinearGradientFillStyleData), "$3")]
[GameMakerDerivedType(typeof(RadialGradientFillStyleData), "$4")]
[GameMakerDerivedType(typeof(BitmapFillStyleData), "$5")]
public class FillStyleData : ResourceBase
{
    public enum FillStyleType
    {
        Invalid = 0,
        Solid = 1,
        Gradient = 2,
        LinearGradient = 3,
        RadialGradient = 4,
        Bitmap = 5,
    }
}
/// <summary>
/// A fill style for solid colors
/// </summary>
[YYVersion(0)]
public class SolidFillStyleData : FillStyleData
{
    /// <summary>
    /// The color of the solid
    /// </summary>
    [GameMakerProperty("rgba")]
    public uint RGBAColor { get; set; }
}

[YYVersion(0)]
public class GradientFillStyleData : FillStyleData { }

[YYVersion(0)]
public class LinearGradientFillStyleData : FillStyleData { }

[YYVersion(0)]
public class RadialGradientFillStyleData : FillStyleData { }

[YYVersion(0)]
public class BitmapFillStyleData : FillStyleData { }
