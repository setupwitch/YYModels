using System.Text.Json.Serialization;

namespace YYModels.Models;

[YYVersion(0)]
[GMResource("folders")]
public class GMFolder : ResourceBase
{
    /// <summary>
    /// The path of the folder.
    /// </summary>
    [GameMakerProperty("folderPath")]
    public string FolderPath { get; set; }
}
    