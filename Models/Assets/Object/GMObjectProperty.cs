namespace YYModels.Models;

/// <remarks>Version 2</remarks>
public class GMObjectProperty : ResourceBase
{
    public enum ObjectPropertyType
    {
        Real,
        Integer,
        String,
        Boolean,
        Expression,
        Resource,
        List,
        Color,
    }
    /// <summary>
    /// Filters for what asset to use in the property.
    /// </summary>
    [GameMakerProperty("filters")]
    public List<string> Filters { get; set; }

    /// <summary>
    /// The items to pick from in the list.
    /// </summary>
    [GameMakerProperty("listItems")]
    public List<string> ListValues { get; set; }

    /// <summary>
    /// Whether the list supports selection of multiple values at once.
    /// </summary>
    [GameMakerProperty("multiselect")]
    public bool IsMultiselect { get; set; }

    /// <summary>
    /// Whether the slider for number values is enabled.
    /// </summary>
    [GameMakerProperty("rangeEnabled")]
    public bool HasRange { get; set; }

    /// <summary>
    /// The maximum value of the range slider.
    /// </summary>
    [GameMakerProperty("rangeMax")]
    public float RangeMax { get; set; }

    /// <summary>
    /// The minimum value of the range slider.
    /// </summary>
    [GameMakerProperty("rangeMin")]
    public float RangeMin { get; set; }

    /// <summary>
    /// The value of the property.
    /// </summary>
    [GameMakerProperty("value")]
    public string Value { get; set; }

    /// <summary>
    /// The variable type of the property.
    /// </summary>
    [GameMakerProperty("varType")]
    public ObjectPropertyType VariableType { get; set; }
}