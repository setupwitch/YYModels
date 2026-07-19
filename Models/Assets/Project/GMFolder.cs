using System.Text.Json.Serialization;

namespace YYModels.Models;

/// <remarks>Version 0</remarks>
[GMResource("folders")]
public class GMFolder : ResourceBase
{
    /// <summary>
    /// The path of the folder.
    /// </summary>
    [GameMakerProperty("folderPath")]
    public string FolderPath { get; set; }
}
    