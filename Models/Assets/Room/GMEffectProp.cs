namespace YYModels.Models;

/// <summary>
/// Effect properties inside of a room layer.
/// </summary>
public class EffectProperty
{
    /// <summary>
    /// The name of the effect
    /// </summary>
    [GameMakerProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// The <see cref="EffectPropertyType"/> of effect to use.
    /// </summary>
    [GameMakerProperty("type")]
    public EffectPropertyType PropertyType { get; set; }

    /// <summary>
    /// The value the effect is set to.
    /// </summary>
    [GameMakerProperty("value")]
    public string Value { get; set; }

    /// <summary>
    /// The type of effect to use.
    /// </summary>
    public enum EffectPropertyType
    {
        /// <summary>
        /// A number value.
        /// </summary>
        Real,
                
        /// <summary>
        /// A hexidecimal color.
        /// </summary>
        /// <example>"#FFFFFFFF"</example>
        Color,
                
        /// <summary>
        /// A sprite name?
        /// </summary>
        Sprite,
    }
}