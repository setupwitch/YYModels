namespace YYModels.Models;

[YYVersion(0)]
public class GMExtensionOption : ResourceBase
{
    /// <summary>
    /// The default value of the option.
    /// </summary>
    [GameMakerProperty("defaultValue")]
    public string DefaultValue { get; set; }

    /// <summary>
    /// The description of the option.
    /// </summary>
    [GameMakerProperty("description")]
    public string Description { get; set; }

    /// <summary>
    /// The display name of the option.
    /// </summary>
    [GameMakerProperty("displayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Whether to export the function to the options INI file.
    /// </summary>
    [GameMakerProperty("exportToINI")]
    public bool ExportToINIFile { get; set; }

    /// <summary>
    /// Unknown, possibly to link two extensions?
    /// </summary>
    [GameMakerProperty("extensionId")]
    public ResourceReference<GMExtension>? ExtensionId { get; set; }

    /// <summary>
    /// The GUID of the option.
    /// </summary>
    [GameMakerProperty("guid")]
    public string Guid { get; set; } = System.Guid.NewGuid().ToString();

    /// <summary>
    /// Whether the option is hidden.
    /// </summary>
    [GameMakerProperty("hidden")]
    public bool IsHidden { get; set; }

    /// <summary>
    /// The Items that can be chosen from in the option.
    /// </summary>
    [GameMakerProperty("listItems")]
    public List<string> ListItems { get; set; } = new();

    /// <summary>
    /// The value type of the option.
    /// </summary>
    [GameMakerProperty("optType")]
    public OptionType Type { get; set; }
        
    public enum OptionType
    {
        Bool = 0,
        Number = 1,
        String = 2,
        FilePath = 3,
        FolderPath = 4,
        Label = 5,
        List = 6,
    }
}